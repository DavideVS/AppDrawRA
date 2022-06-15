using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

/*
  Script sobre la última escena que permite mover y mover un cubo en los distintos planos,
  solo horizontales, que se recrean en RA.
*/

[RequireComponent(typeof(ARRaycastManager))]
public class AddObj : MonoBehaviour
{
    public GameObject gameObjectToInstantiate;

    private GameObject spawnedObject;
    private ARRaycastManager _arRaycastManager;
    private Vector2 touchPosition;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
    // Start is called before the first frame update
    private void Awake() {
        _arRaycastManager = GetComponent<ARRaycastManager>();
    }

    bool TryGetTouchPosition(out Vector2 touchPosition) {
        if (Input.touchCount > 0) {
            touchPosition = Input.GetTouch(index:0).position;
            return true;
        }
        touchPosition = default;
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!TryGetTouchPosition(out Vector2 touchPosition))
           return;
        if (_arRaycastManager.Raycast(touchPosition, hits, trackableTypes: TrackableType.PlaneWithinPolygon))
        {
            var hitPose = hits[0].pose;

            if (spawnedObject == null)
            {
                spawnedObject = Instantiate (gameObjectToInstantiate, hitPose.position, hitPose.rotation);
            }
            else
            {
                spawnedObject.transform.position = hitPose.position;
            }
        }
        
    }
}