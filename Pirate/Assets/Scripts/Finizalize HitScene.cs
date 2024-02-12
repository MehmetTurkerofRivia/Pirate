using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinizalizeHitScene : MonoBehaviour
{
    [SerializeField] GameObject Main;
    [SerializeField] GameObject Hit;
    [SerializeField] GameObject panel2;
    void Update()
    {
        Main.SetActive(true);
        Hit.SetActive(false);   
        panel2.SetActive(false);
    }

}
