using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeAnimation : MonoBehaviour

{


    private Vector3 startPos;
    public Vector3 endPosAddition;
    private Vector3 endPos;
    // Movement speed in units per second.
    public float speed = 1F;

    public bool endPoint = false;


    // Total distance between the markers.
    private float journeyLength;

    void Start()
    {
        // Keep a note of the time the movement started.

        startPos = transform.position;
        endPos = new Vector3(transform.position.x + endPosAddition.x, transform.position.y + endPosAddition.y, transform.position.z + endPosAddition.z);


        // Calculate the journey length.
        journeyLength = Vector3.Distance(startPos, endPos);
    }

    void Update()
    {
        // Distance moved equals elapsed time times speed..
        float distCovered = Time.time * speed;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;


        // Set our position as a fraction of the distance between the markers.
        transform.position = Vector3.Lerp(startPos, endPos, fractionOfJourney);


        if(endPoint) {
            if(fractionOfJourney >= 1.0f){
                gameObject.SetActive(false);
            }
        }
    }


}
