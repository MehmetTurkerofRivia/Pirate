using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    [SerializeField] Text RepairAbility;
    [SerializeField] Text ObservingAbility;
    [SerializeField] Text CrewnName;
    [SerializeField] CreatingnewPirate crewList;
    public static PirateScriptableObject Pirate;
    private int randomPirate;
    private void Start()
    {
        if ((Pirate == null) )
        {
            randomPirate = Random.Range(0, crewList.list.Count);
            Pirate = crewList.list[randomPirate];
            crewList.list[randomPirate].isPirateAvaliable = false;
        }                                   
        
        RepairAbility.text = "" + Pirate.PirateRepairAbility;
        ObservingAbility.text = "" + Pirate.PirateHitChance;
        CrewnName.text = "" + Pirate.PirateName;
    }
}
