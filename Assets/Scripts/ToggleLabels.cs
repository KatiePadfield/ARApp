using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLabels : MonoBehaviour
{
    public void ToggleVisibilityInside()
    {
        GameObject labels = GameObject.Find("Labels").transform.GetChild(1).gameObject;

        if (labels.activeSelf)
        {
            labels.SetActive(false);
        }
        else
        {
            labels.SetActive(true);
        }

    }

    public void ToggleVisibilityOutside()
    {
        GameObject labels = GameObject.Find("Labels").transform.GetChild(0).gameObject;

        if (labels.activeSelf)
        {
            labels.SetActive(false);
        }
        else
        {
            labels.SetActive(true);
        }
    }
}
