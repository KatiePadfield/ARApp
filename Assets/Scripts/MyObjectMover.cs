using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;
using TMPro;

public class MyObjectMover : MonoBehaviour
{

    public GameObject movableObject;
    public ARRaycastManager raycastManager;

    public TextMeshProUGUI log;


    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                log.text = ("Touched object: " + hit.collider.name);
                movableObject.transform.position = hit.point;
                // Do something with the hit object
            }
        }

    }

    // void Update()
    // {

    //     if (Input.touchCount > 0)
    //     {
    //         Touch touch = Input.GetTouch(0);
    //         Vector3 Position = touch.position;
    //         transform.position = Position;
    //     }


    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         Vector3 Position = Input.mousePosition;
    //         transform.position = Position;
    //     }

    // }

}

