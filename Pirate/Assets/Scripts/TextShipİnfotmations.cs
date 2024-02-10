using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextShipİnfotmations : MonoBehaviour
{
    [SerializeField] Text ShipHitChance;
    [SerializeField] PirateScriptableObject pirate;

    private void Update()
    {
        ShipHitChance.text = "Your Hit Chance : " + (pirate.PirateHitChance + Cannon1.CannonHitChance + Observe.ExtraHitChance);

    }
}
