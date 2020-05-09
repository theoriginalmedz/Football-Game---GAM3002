using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Uimage : MonoBehaviour
{
    public Image Mathew;  //Add reference to UI Text here via the inspector
    private float timeToAppear = 3f;
    private float timeWhenDisappear = 10f;

    //Call to enable the text, which also sets the timer
    public void EnableText()
    {
        Mathew.enabled = true;
        timeWhenDisappear = Time.time + timeToAppear;
    }

    //We check every frame if the timer has expired and the text should disappear
    void Update()
    {
        if (Mathew.enabled && (Time.time >= timeWhenDisappear))
        {
            Mathew.enabled = false;
        }
    }
}
