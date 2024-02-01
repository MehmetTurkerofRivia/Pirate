using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextShipİnfotmations : MonoBehaviour
{
    [SerializeField] Text ShipHitChance;

    private void Update()
    {
        ShipHitChance.text = "Your Hit Chance : " + (Pirate.PirateHitChance + Cannon1.CannonHitChance + Observe.ExtraHitChance);

    }
}
