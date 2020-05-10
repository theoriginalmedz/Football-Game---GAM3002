using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballRemove6lives2B : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        sixLives2B.health -= 1;
    }
}
