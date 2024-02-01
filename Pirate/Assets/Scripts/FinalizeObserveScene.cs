using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalizeObserveScene : MonoBehaviour
{
    [SerializeField] GameObject Observer;
    void Update()
    {
        Observer.SetActive(false);
    }
}
