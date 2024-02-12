using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

[CreateAssetMenu(menuName = "Scriptable Object/ListOfPirate")]
public class CreatingnewPirate : ScriptableObject
{                                                  
    public List<PirateScriptableObject> list;
    public PirateScriptableObject selectedpirate;
    private void Awake()
    {
        selectedpirate = TextManager.Pirate;
    }
}


