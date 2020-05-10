using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
     SwipeScript swipe;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            ScoreGoal.scorevalue += 1;
            Debug.Log("goal");
            
        }
    }

  
}
