using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour
{
    public Text text;  //Add reference to UI Text here via the inspector
    private float timeToAppear = 3f;
    private float timeWhenDisappear = 3f;

    //Call to enable the text, which also sets the timer
    public void EnableText()
    {
        text.enabled = true;
        timeWhenDisappear = Time.time + timeToAppear;
    }

    //We check every frame if the timer has expired and the text should disappear
    void Update()
    {
        if (text.enabled && (Time.time >= timeWhenDisappear))
        {
            text.enabled = false;
        }
    }
}
