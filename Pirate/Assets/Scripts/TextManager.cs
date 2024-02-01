using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    [SerializeField] Text RepairAbility;
    [SerializeField] Text ObservingAbility;
    private void Start()
    {
        RepairAbility.text = "" + Pirate.PirateRepairAbility;
        ObservingAbility.text = "" + Pirate.PirateHitChance;
    }
}
