using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomActive : MonoBehaviour
{
    public GameObject[] objects;
    private int currentIndex = 0;
    public float elapsedTime = 0f;
    public float repeatTime = 10f;

    // Update is called once per frame
    void Update()
    {
         elapsedTime += Time.deltaTime;
         if (elapsedTime > repeatTime) {

             int newIndex = Random.Range (0, objects.Length);
             objects [currentIndex].SetActive (false);
             currentIndex = newIndex;
             objects [currentIndex].SetActive (true);
             elapsedTime -= repeatTime;
         }
    }
}
