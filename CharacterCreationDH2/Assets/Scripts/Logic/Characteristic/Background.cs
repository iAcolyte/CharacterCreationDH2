using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background 
{
    private GameStat.BackgroundName name;
    private List<List<Skill>> skills = new List<List<Skill>>();
    private List<List<string>> talents = new List<List<string>>();
    private List<List<string>> equipment = new List<List<string>>();
    private List<GameStat.Inclinations> inclinations = new List<GameStat.Inclinations>();
    private MechImplants mechImplants;
    private string pathBackground;
    private List<Skill> chosenSkills = new List<Skill>();
    private List<string> chosenTalents = new List<string>();
    private List<string> chosenEquipments = new List<string>();
    private GameStat.Inclinations chosenInclination;

    public Background(GameStat.BackgroundName name, List<List<Skill>> skills, List<List<string>> talents, List<List<string>> equipment, List<GameStat.Inclinations> inclinations, 
        MechImplants mechImplants = null)
    {
        this.name = name;
        this.skills = new List<List<Skill>>(skills);
        this.talents = new List<List<string>>(talents);
        this.equipment = new List<List<string>>(equipment);
        this.inclinations = new List<GameStat.Inclinations>(inclinations);
        this.mechImplants = mechImplants;
        pathBackground = $"{Application.dataPath}/Images/Backgrounds/{name}/";
    }

    public void SetChosen(List<Skill> chosenSkills, List<string> chosenTalents, List<string> chosenEquipments, GameStat.Inclinations chosenInclination)
    {
        this.chosenSkills = new List<Skill>(chosenSkills);
        this.chosenTalents = new List<string>(chosenTalents);
        this.chosenEquipments = new List<string>(chosenEquipments);
        this.chosenInclination = chosenInclination;
    }

    public string PathBackground { get => pathBackground; }
    public List<List<string>> Talents { get => talents; }
    public List<List<Skill>> Skills { get => skills; }
    public List<List<string>> Equipment { get => equipment; }
    public List<GameStat.Inclinations> Inclinations { get => inclinations;  }
    public List<Skill> ChosenSkills { get => chosenSkills;}
    public List<string> ChosenTalents { get => chosenTalents;}
    public List<string> ChosenEquipments { get => chosenEquipments;}
    public GameStat.Inclinations ChosenInclination { get => chosenInclination;}
}
