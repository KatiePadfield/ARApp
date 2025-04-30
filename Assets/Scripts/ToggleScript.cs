using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleScript : MonoBehaviour
{


    public void SetActive(GameObject _GameObject)
    {

        _GameObject.SetActive(true);

    }

    public void SetInactive(GameObject _GameObject)
    {

        _GameObject.SetActive(false);

    }

    public void Toggle(GameObject _GameObject)
    {

        if (_GameObject.activeSelf)
        {
            _GameObject.SetActive(false);
        }
        else
        {
            _GameObject.SetActive(true);
        }

    }

}
