using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRemove4Lives : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        LiveManagement4.health -= 1;
    }
}
