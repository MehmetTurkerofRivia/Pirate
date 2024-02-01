using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanWeFire : MonoBehaviour
{
    public static bool isCrewSelected = false;
    public bool isCannonSelected = false;
    [SerializeField] GameObject FireButton;
    public static int hitChance;
    public bool isHit = false;
    public int Dice;
    [SerializeField] GameObject Main;
    [SerializeField] GameObject Hit;
    [SerializeField] GameObject Dodge;


    void Update()
    {
    if ((isCrewSelected == true) && (isCannonSelected == true) && (Cannon1.Isload == true))
        {
            FireButton.SetActive(true);             
        }
    else
        {
            FireButton.SetActive(false);
        }
        Debug.Log(hitChance);
    }

    public void CrewActivateButton()
    {
        isCrewSelected = true;
    }

    public void CannonActivateButton()
    {
        isCannonSelected = true;
    }
    public void CannonDeactivateButton()
    {
        isCannonSelected=false;
    }

    public void CrewDeactivateButton()
    {
        isCrewSelected=false;
    }

    public void Fire()
    {
        StartCoroutine(fireButtonCoolDown());
    }

    IEnumerator fireButtonCoolDown()
    {
        Cannon1.Isload = false;
        yield return new WaitForSeconds(4f);
        Cannon1.Isload = true;
        HitStage();
    }

    public void HitStage()
    {
        hitChance = Pirate.PirateHitChance + Cannon1.CannonHitChance + Observe.ExtraHitChance;
        Dice = Random.Range(1, 100);
        if (hitChance > Dice)
        {
            Main.SetActive(false);
            Hit.SetActive(true);
        }
        else
        {
            Main.SetActive(false);
            Dodge.SetActive(true);
        }
    }
}
