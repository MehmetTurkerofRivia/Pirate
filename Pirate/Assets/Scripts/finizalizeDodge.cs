using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finizalizeDodge : MonoBehaviour
{
    [SerializeField] GameObject main;
    [SerializeField] GameObject dodge;
    [SerializeField] GameObject panel1;
    [SerializeField] GameObject panel2;
    void Update()
    {
        main.SetActive(true);
        dodge.SetActive(false);
        panel1.SetActive(false);
        panel2.SetActive(false);
    }

}
