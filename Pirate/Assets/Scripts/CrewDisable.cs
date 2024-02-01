using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrewDisable : MonoBehaviour
{
    [SerializeField] GameObject CrewShadowPanel;
    [SerializeField] GameObject CrewButtonDisable;

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
}
