using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRemove4 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        LivesOnlyFour.health -= 1;
    }
}
