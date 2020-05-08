using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRemove : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Lives.health -= 1;
    }
}
