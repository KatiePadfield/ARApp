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
    public List<Vector3> startPositions;
    public List<GameObject> movedObjects;
    public GameObject trackedObject;

    public ARRaycastManager raycastManager;

    public GameObject test;

    public LayerMask layerMaskPlane;
    public LayerMask layerMaskObject;


    void Start()
    {
        raycastManager = GameObject.Find("XR Origin").GetComponent<ARRaycastManager>();
    }


    void Update()
    {
        Touch touch = Input.GetTouch(0);
        Ray ray = Camera.main.ScreenPointToRay(touch.position);
        if (Input.touchCount > 0)
        {
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    OnTouchDown(touch, ray);
                    break;

                case TouchPhase.Ended:
                    OnTouchUp(touch, ray);
                    break;
            }


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

    void OnTouchDown(Touch touch, Ray ray)
    {

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMaskObject))
        {
            trackedObject = hit.transform.gameObject;
            int i = 0;
            foreach (GameObject _object in movableObjects)
            {
                if (_object == trackedObject)
                {
                    Vector3 pos = startPositions[i];

                    if (movedObjects.Contains(trackedObject))
                    {
                        if (trackedObject.transform.localPosition != pos)
                        {
                            trackedObject.transform.localPosition = pos;
                            movedObjects.Remove(trackedObject);
                            trackedObject = null;
                        }
                        return;
                    }
                }
                i++;
            }

        }





    }

    void OnTouchUp(Touch touch, Ray ray)
    {

        if(trackedObject != null)
        {
        movedObjects.Add(trackedObject);
        trackedObject = null;
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

