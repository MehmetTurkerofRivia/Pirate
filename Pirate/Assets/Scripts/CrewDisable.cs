using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrewDisable : MonoBehaviour
{
    [SerializeField] GameObject CrewShadowPanel;
    [SerializeField] GameObject CrewButtonDisable;

<<<<<<< HEAD
    //void Update()
    //{
    //    if (pirateData != null && crewShadowPanel != null)
    //    {
    //        CrewButtonDisable.SetActive(false);
    //    }

    //    else
    //    {
    //        CrewButtonDisable.SetActive(true);
    //    }
    //}
=======
    void Update()
    {
        if (CrewShadowPanel.activeInHierarchy)
        {
            CrewButtonDisable.SetActive(false);
        }
        else
        {
            CrewButtonDisable.SetActive(true);
        }
    }
>>>>>>> parent of 1ed4594 (prefab yapıldı)
}
