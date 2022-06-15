using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorRandomly : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            this.GetComponent<Renderer> ().material.color = Color.HSVToRGB (Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));
        }       
    }
}
