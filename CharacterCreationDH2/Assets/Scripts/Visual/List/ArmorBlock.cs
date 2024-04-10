using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArmorBlock : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textName, textPlace, textArmorPoint, textMaxAg, textWeight;
    [SerializeField] ArmorOnBody onBody;
    bool isEmpty = true;
    public bool IsEmpty { get => isEmpty; }

    public void FillBlock(Armor armor, List<MechImplant> mechImplants)
    {
        textName.text = armor.Name;
        textPlace.text = armor.PlaceArmor;
        textArmorPoint.text = armor.ArmorPoint.ToString();
        textMaxAg.text = armor.MaxAgil.ToString();
        textWeight.text = armor.Weight.ToString();
        
        onBody.SetArmor(armor, mechImplants);
        isEmpty = false;
    }
}
