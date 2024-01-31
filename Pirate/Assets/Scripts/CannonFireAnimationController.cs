using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CannonFireAnimationController : MonoBehaviour
{
    private Animator animator;
    private bool isAnimationAvalible = true;
    [SerializeField] GameObject smoke;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Fire()
    {
            if(isAnimationAvalible == true)
        {
            StartCoroutine(fire());
        }
    }
    IEnumerator fire()
    {
        animator.SetBool("isCannonFire", true);
        isAnimationAvalible = false;
        smoke.SetActive(true);        
        yield return new WaitForSeconds(4f);
        animator.SetBool("isCannonFire", false);
        isAnimationAvalible = true;
        smoke.SetActive(false);
    }
}

