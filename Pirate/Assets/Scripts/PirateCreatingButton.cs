using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateCreatingButton : MonoBehaviour
{
    [SerializeField] RandomPirateCreator a;
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Space)) 
        {
            a.PirateCreator();    
        }   
    }
}
