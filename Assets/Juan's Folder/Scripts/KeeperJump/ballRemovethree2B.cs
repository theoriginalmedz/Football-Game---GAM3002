using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballRemovethree2B : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
       threeLives2B.health -= 1;
    }
}
