using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFireAnim : MonoBehaviour
{
    public int animationDuration = 1;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Update()
    {
        StartCoroutine("fire");
    }

    IEnumerable fire()
    {
        animator.SetBool("isCannonFire", true);
        yield return new WaitForSeconds(animationDuration);
        animator.SetBool("isCannonFire", false);
    }
}
    
}
