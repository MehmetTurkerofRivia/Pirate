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
    public bool isPirateAvaliable = true;

}

public class PanelDeActivator : MonoBehaviour
{
    public static GameObject panel;
    private void Start()
    {
        panel =.gameObject.CompareTag("Panel")
    }
}
