using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCAnnon : MonoBehaviour
{
    [SerializeField] Text Damage;
    [SerializeField] Text HitChance;

    private void Start()
    {
        Damage.text = "" + Cannon1.CannonDamage;
        HitChance.text = "" + Cannon1.CannonHitChance;
    }
}
