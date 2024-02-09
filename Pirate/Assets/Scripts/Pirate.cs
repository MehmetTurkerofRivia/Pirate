using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCrew", menuName ="NewPirate")]
public class Pirate : ScriptableObject
{
    [SerializeField] string PirateName;
    public int PirateHitChance;
    public int PirateRepairAbility;     
}
