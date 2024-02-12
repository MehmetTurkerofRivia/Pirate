using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observe : MonoBehaviour
{
    [SerializeField] GameObject ObserveButton;
    [SerializeField] PirateScriptableObject pirate;
    public static int ExtraHitChance = 0;
    void Update()
    {
        if(CanWeFire.isCrewSelected == true)
        {
            ObserveButton.SetActive(true);
        }    
    }

    public void observe()
    {
        ExtraHitChance += (CreatingnewPirate.selectedpirate.PirateHitChance / 10);
    }
}
