using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCrew", menuName = "NewPirate")]
public class PirateScriptableObject : ScriptableObject
{
    public string PirateName;
    public int PirateHitChance;
    public int PirateRepairAbility;
    public bool isPirateAvaliable = true;
    public GameObject panel;
}
