using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGoal : MonoBehaviour
{
    public static int scorevalue = 0;
    Text Goals;

    void Start()
    {
        Goals = GetComponent<Text>();
    }


    void Update()
    {
        Goals.text = "Goals: " + scorevalue;
    }
}