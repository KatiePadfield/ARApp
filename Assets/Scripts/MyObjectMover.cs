using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;
using TMPro;

public class MyObjectMover : MonoBehaviour
{

    public List<GameObject> movableObjects;
    public GameObject trackedObject;

    public ARRaycastManager raycastManager;


    public LayerMask layerMaskPlane;
    public LayerMask layerMaskObject;

    void Start()
    {
        raycastManager = GameObject.Find("XR Origin").GetComponent<ARRaycastManager>();
    }


    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMaskObject))
            {

                trackedObject = hit.transform.gameObject;
                //movableObject.transform.position = hit.point;
                // Do something with the hit object
            }

            if (trackedObject != null)
            {
                RaycastHit hit2;

                if (Physics.Raycast(ray, out hit2, Mathf.Infinity, layerMaskPlane))
                {
                    trackedObject.transform.position = hit2.point;
                    // Do something with the hit object
                }
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

