using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballRemove6lives2A : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        sixLives2A.health -= 1;
    }
}
