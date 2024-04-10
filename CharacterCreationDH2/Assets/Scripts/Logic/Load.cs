using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Load
{
    public void LoadCharacter(Character character, string path)
    {
        //var path = $"{Application.dataPath}/StreamingAssets/CharacterSheets//.JSON";

        string allText = File.ReadAllText(path);
        //string[] data = File.ReadAllLines(path);
        allText = allText.Replace(Environment.NewLine, string.Empty);
        string[] data = allText.Split(new[] {'{','}' }, StringSplitOptions.RemoveEmptyEntries);

        for(int i = 0; i < data.Length; i++)
        {
            data[i] = $"{{ {data[i]} }}";
        }

        SaveLoadCharacter loadCharacter = JsonUtility.FromJson<SaveLoadCharacter>(data[0]);

        List<SaveLoadCharacteristic> characteristics = new List<SaveLoadCharacteristic>();
        for (int i = 1; i < character.Characteristics.Count + 1; i++)
        {
            SaveLoadCharacteristic characteristic = JsonUtility.FromJson<SaveLoadCharacteristic>(data[i]);
            characteristics.Add(characteristic);
        }

        List<SaveLoadSkill> skills = new List<SaveLoadSkill>();
        for(int i = 1 + character.Characteristics.Count + 1; i < character.Skills.Count; i++)
        {
            SaveLoadSkill skill = JsonUtility.FromJson<SaveLoadSkill>(data[i]);
            skills.Add(skill);
        }

        List<Equipment> equipments = new List<Equipment>();       
        for(int i = 1 + character.Characteristics.Count + character.Skills.Count; i < data.Length; i++)
        {
            JSONTypeReader typeReader = JsonUtility.FromJson<JSONTypeReader>(data[i]);
            if (typeReader.typeEquipment == Equipment.TypeEquipment.Thing.ToString())
            {
                JSONEquipmentReader jSONSmall = JsonUtility.FromJson<JSONEquipmentReader>(data[i]);
                equipments.Add(new Equipment(jSONSmall.name, jSONSmall.description, jSONSmall.rarity, jSONSmall.amount, jSONSmall.weight));
            }
            else if (typeReader.typeEquipment == Equipment.TypeEquipment.Melee.ToString())
            {
                JSONMeleeReader meleeReader = JsonUtility.FromJson<JSONMeleeReader>(data[i]);
                equipments.Add(new Weapon(meleeReader));
            }
            else if (typeReader.typeEquipment == Equipment.TypeEquipment.Range.ToString())
            {
                JSONRangeReader rangeReader = JsonUtility.FromJson<JSONRangeReader>(data[i]);
                equipments.Add(new Weapon(rangeReader));
            }
            else if (typeReader.typeEquipment == Equipment.TypeEquipment.Grenade.ToString())
            {
                JSONGrenadeReader grenadeReader = JsonUtility.FromJson<JSONGrenadeReader>(data[i]);
                equipments.Add(new Weapon(grenadeReader));
            }
            else if (typeReader.typeEquipment == Equipment.TypeEquipment.Armor.ToString())
            {
                JSONArmorReader armorReader = JsonUtility.FromJson<JSONArmorReader>(data[i]);
                equipments.Add(new Armor(armorReader));
            }
        }

        character.LoadData(loadCharacter, characteristics, skills, equipments);
    }

}
