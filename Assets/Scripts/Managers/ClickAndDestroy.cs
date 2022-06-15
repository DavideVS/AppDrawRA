using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDestroy : MonoBehaviour
{
    //public GameObject Original;

    void Start() {
        //Original = GameObject.FindWithTag ("Original");
        //Original.active = false;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            //Original.active = true;
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit)) {
                BoxCollider bc = hit.collider as BoxCollider;
                if (bc != null) {
                    //Destroy(Original);
                    Destroy(bc.gameObject);
                    //Destroy(bc.gameObject("Original"));
                }
            }
            /*
            Original = GameObject.FindWithTag ("Original");
            Destroy(Original);
            */
        }  
    }
}
