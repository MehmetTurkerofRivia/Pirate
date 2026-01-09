using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

[CreateAssetMenu(fileName = "NewCrew", menuName = "Scriptable Object/NewPirate")]
public class PirateScriptableObject : ScriptableObject
{
    public string PirateName;
    public int PirateHitChance;
    public int PirateRepairAbility;
}
