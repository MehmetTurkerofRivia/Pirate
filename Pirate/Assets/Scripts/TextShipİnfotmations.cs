using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextShipİnfotmations : MonoBehaviour
{
    [SerializeField] Text ShipHitChance;
    private void Update()
    {
        if (CreatingnewPirate.selectedpirate == null)
        {
            ShipHitChance.text = "Your Hit Chance : " + (Cannon1.CannonHitChance);
        }
        else
        {
            ShipHitChance.text = "Your Hit Chance : " + (CreatingnewPirate.selectedpirate.PirateHitChance + Cannon1.CannonHitChance + Observe.ExtraHitChance);
        }
        

    }
}
                            