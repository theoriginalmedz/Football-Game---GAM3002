using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGoalScored : MonoBehaviour
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

        public void OnTriggerStay(Collider other)
        {
            if (other.gameObject.name == "Ball")
            {
                ScoreGoal.scorevalue += 0;
                Debug.Log("goal");

            }
        }

        //public void OnTriggerExit(Collider other)
        //{
        //    if (other.gameObject.name == "Ball")
        //    {
        //        swipe.ReturnBall();
        //    }
        //}
    }
