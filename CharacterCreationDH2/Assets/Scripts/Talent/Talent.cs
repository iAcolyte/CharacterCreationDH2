using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;

public class Talent
{
    private string name;
    private string textDescription, shortDescription, listOfRequrements;
    private GameStat.Inclinations[] inclinations = new GameStat.Inclinations[2];
    private List<Characteristic> requirementCharacteristics = new List<Characteristic>();
    private List<Skill> requirementSkills = new List<Skill>();
    private List<MechImplants> requirementImplants = new List<MechImplants>();
    private List<Talent> requirementTalents = new List<Talent>();
    private int requirementPsyRate;
    private int requirementInsanity = 0, requirementCorruption = 0;
    private bool isCanTaken, isRepeatable, isImplant;
    private int rank;
    private int cost;

    public string Name { get { return  name; } }
    public string Description { get { return textDescription; } }
    public GameStat.Inclinations[] Inclinations { get { return inclinations; } }
    public bool IsCanTaken { get => isCanTaken; }
    public int Cost { get => cost; }
    public string ShortDescription { get => shortDescription; }
    public bool IsImplant { get => isImplant; }

    public Talent(string path, bool fullTalent)
    {
        string[] data = File.ReadAllLines(path + "/Param.JSON");
        JSONTalentReader talentReader = JsonUtility.FromJson<JSONTalentReader>(data[0]);
        name = talentReader.name;
        inclinations[0] = (GameStat.Inclinations)Enum.Parse(typeof(GameStat.Inclinations), talentReader.inclinationFirst);
        inclinations[1] = (GameStat.Inclinations)Enum.Parse(typeof(GameStat.Inclinations), talentReader.inclinationSecond);
        rank = talentReader.rank;
        isCanTaken = talentReader.canActivate;
        isRepeatable = talentReader.repeatable;
        textDescription = ReadText(path + "/��������.txt");
        shortDescription = ReadText(path + "/������� ��������.txt");
        if(Directory.Exists(path + "/Req"))
        {
            listOfRequrements = "���������� ��� �������.\n";
            path += "/Req";
            if (Directory.Exists(path + "/Characteristics"))
            {
                listOfRequrements += "��������������:";
                foreach (GameStat.CharacterName charName in Enum.GetValues(typeof(GameStat.CharacterName)))
                {                    
                    string searchFile = $"{path}/Characteristics/{charName}.txt";
                    if (File.Exists(searchFile))
                    {
                        requirementCharacteristics.Add(new Characteristic(charName,int.Parse(ReadText(searchFile))));
                        listOfRequrements += $" {requirementCharacteristics[^1].Name} - {requirementCharacteristics[^1].Amount},";
                    }
                }
            }

            listOfRequrements = CheckLastSymbol(listOfRequrements);

            if(Directory.Exists(path + "/Skills"))
            {
                listOfRequrements += "������:";
                string[] files = Directory.GetFiles(path + "/Skills", "*.JSON");
                foreach(string file in files)
                {
                    string[] jSonData = File.ReadAllLines(file);
                    JSONSmallSkillLoader jSONSmall = JsonUtility.FromJson<JSONSmallSkillLoader>(jSonData[0]);
                    requirementSkills.Add(new Skill(jSONSmall.name, jSONSmall.lvl, jSONSmall.internalName));
                    listOfRequrements += $" {requirementSkills[^1].Name} - {requirementSkills[^1].LvlLearned},";
                }
            }

            listOfRequrements = CheckLastSymbol(listOfRequrements);
            if (File.Exists(path + "/ReqImplants.txt"))
            {
                string textImplants = ReadText(path + "/ReqImplants.txt");
                var implants = textImplants.Split(new char[] { '/' }).ToList();
                listOfRequrements += " ��������:";
                isImplant = true;
                foreach (string implant in implants)
                {
                    requirementImplants.Add(new MechImplants(implant));
                    listOfRequrements += $" {requirementImplants[^1].Name},";
                }
            }

            listOfRequrements = CheckLastSymbol(listOfRequrements);

            if (File.Exists(path + "/ReqTalents.txt"))
            {
                string textTalents = ReadText(path + "/ReqTalents.txt");
                var talents = textTalents.Split(new char[] { '/' }).ToList();
                listOfRequrements += "�������:";
                foreach (string talent in talents)
                {
                    requirementTalents.Add(new Talent(talent));
                    listOfRequrements += $" {requirementTalents[^1].Name},";
                }
            }
            listOfRequrements = CheckLastSymbol(listOfRequrements);

            if (File.Exists(path + "/ReqCorruption.txt"))
            {
                requirementCorruption = int.Parse(ReadText(path + "/ReqCorruption.txt"));
                listOfRequrements += $" ����� ����� {requirementCorruption}.";
            }

            if (File.Exists(path + "/ReqInsanity.txt"))
            {
                requirementInsanity = int.Parse(ReadText(path + "/ReqInsanity.txt"));
                listOfRequrements += $" ����� ������� {requirementInsanity}.";
            }

            if(File.Exists(path + "/ReqPsy.txt"))
            {
                requirementPsyRate = int.Parse(ReadText(path + "/ReqPsy.txt"));
                listOfRequrements += $" ��� ������� {requirementPsyRate}.";
            }
            else
            {
                requirementPsyRate = 0;
            }
            textDescription = textDescription + '\n' + listOfRequrements;
        }        
    }

    private string CheckLastSymbol(string text)
    {
        if (text.EndsWith(","))
        {
            string tempstring = text.TrimEnd(',');
            return tempstring + ". ";
        }
        else
        {
            return text;
        }
    }
    private string ReadText(string nameFile)
    {
        string txt;
        using (StreamReader _sw = new StreamReader(nameFile, Encoding.Default))
        {
            txt = (_sw.ReadToEnd());
            _sw.Close();
        }
        return txt;
    }
    public Talent(string name)
    {
        this.name = name;
    }

    public bool IsTalentAvailable(List<Characteristic> characteristicsOfCharacter,
        List<Skill> skillsOfCharacter, List<MechImplants> implantsOfCharacter, List<Talent> talentsOfCharacter, int corruption, int insanity, int characterPsyRate)
    {
        if(CheckCharacteristic(characteristicsOfCharacter) && CheckSkills(skillsOfCharacter) && CheckImplants(implantsOfCharacter) && CheckTalents(talentsOfCharacter) && isCanTaken
            && CheckTalentRepeat(talentsOfCharacter) && insanity >= requirementInsanity && corruption >= requirementCorruption && characterPsyRate >= requirementPsyRate)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool CheckTalentRepeat(List<Talent> talentsOfCharacter)
    {
        if (!isRepeatable)
        {
            foreach (Talent talent in talentsOfCharacter)
            {
                if (string.Compare(talent.Name, name, true) == 0)
                {
                    return false;
                }
            }
        }
        
        return true;
    }
    private bool CheckCharacteristic(List<Characteristic> characteristicsOfCharacter)
    {
        int amountReq = requirementCharacteristics.Count;
        if(amountReq == 0)
        {
            return true;
        }
        for (int i = 0; i < amountReq; i++)
        {
            for(int j = 0; j < characteristicsOfCharacter.Count; j++)
            {
                if(requirementCharacteristics[i].InternalName == characteristicsOfCharacter[j].InternalName)
                {
                    if (requirementCharacteristics[i].Amount > characteristicsOfCharacter[j].Amount)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                        
                }
            }

        }
        return true;
    }

    private bool CheckSkills(List<Skill> skillsOfCharacter)
    {
        int amountReq = requirementSkills.Count;
        if (amountReq == 0)
        {
            return true;
        }
        for (int i = 0; i < amountReq; i++)
        {
            for(int j = 0; j < skillsOfCharacter.Count; j++)
            {
                if(string.Compare(requirementSkills[i].Name,skillsOfCharacter[j].Name,true) == 0)
                {
                    if(requirementSkills[i].LvlLearned > skillsOfCharacter[j].LvlLearned)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
        return true;
    }

    private bool CheckImplants(List<MechImplants> implantsOfCharacter)
    {
        
        int amountReq = requirementImplants.Count;
        if (amountReq == 0)
        {
            return true;
        }
        
        int sum = 0;
        for (int i = 0; i < amountReq; i++)
        {
            for (int j = 0; j < implantsOfCharacter.Count; j++)
            {
                if(string.Compare(requirementImplants[i].Name, implantsOfCharacter[j].Name, true) == 0)
                {
                    sum += 1;
                }
            }
        }

        if(sum == amountReq)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private bool CheckTalents(List<Talent> talentsOfCharacter)
    {
        int amountReq = requirementTalents.Count;
        if (amountReq == 0)
        {
            return true;
        }
        int sum = 0;
        for (int i = 0; i < amountReq; i++)
        {
            for (int j = 0; j < talentsOfCharacter.Count; j++)
            {
                if (string.Compare(requirementTalents[i].Name, talentsOfCharacter[j].Name, true) == 0)
                {
                    sum += 1;
                }
            }
        }

        if (sum == amountReq)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public void CalculateCost(List<GameStat.Inclinations> inclinations)
    {
        int sum = 0;
        foreach (GameStat.Inclinations incl in inclinations)
        {
            if(incl == this.inclinations[0] || incl == this.inclinations[1])
            {
                sum++;
            }
        }
        cost = 300 * (1 + rank) - 150 * (rank + sum);
    }
}
