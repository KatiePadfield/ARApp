using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation; // include xr library

public class ImageTracker : MonoBehaviour
{
    [SerializeField]
    ARTrackedImageManager m_TrackedImageManager; 
    public GameObject eyePrefab; //Prefab you want to appear on marker image

//    public GameObject planeMap;
    
    void OnEnable() => m_TrackedImageManager.trackedImagesChanged += OnChanged;

    void OnDisable() => m_TrackedImageManager.trackedImagesChanged -= OnChanged;

    void OnChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
    	// When the camera picks up a new image marker Unity adds a game object to it called newImage, this will stick to maker.
        foreach (ARTrackedImage newImage in eventArgs.added)
        {
        	// Create new copy of your prefab
        	GameObject newObject = GameObject.Instantiate(eyePrefab);
        	// parent prefab to the newImage so that they stick together.
			newObject.transform.SetParent(newImage.transform, false);

            // GameObject newObject2 = GameObject.Instantiate(planeMap);
        	// // parent prefab to the newImage so that they stick together.
			// newObject.transform.SetParent(newImage.transform, false);
        }
    }
}