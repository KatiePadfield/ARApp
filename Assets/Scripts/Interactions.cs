using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Interactions : MonoBehaviour
{

    public GameObject EyeAnimationScript;

    // public XRRayInteractor _rayInteractor;

    // private bool isDragging = false;
   




    public void selected()
    {
        EyeAnimationScript.GetComponent<EyeAnimation>().enabled=true;
    }

    //  public void OnSelectEntered()
    // {
    //     // Start dragging the object
    //     isDragging = true;
    // }

    // public void OnSelectExited()
    // {
    //     // Stop dragging the object
    //    isDragging = false;
    // }

    // public void Update(){
    //     if(isDragging && _rayInteractor != null){
    //         Ray ray = new Ray(_rayInteractor.transform.position,_rayInteractor.transform.forward);
    //     }
    // }


    
}