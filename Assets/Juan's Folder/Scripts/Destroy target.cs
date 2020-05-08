using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroytarget : MonoBehaviour
{
   

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ball")
        {
            Destroy(gameObject);
        }
    }
}
