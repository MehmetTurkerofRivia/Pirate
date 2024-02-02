using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observe : MonoBehaviour
{
    [SerializeField] GameObject ObserveButton;
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
        ExtraHitChance += (Pirate.PirateHitChance / 10);
    }
}
