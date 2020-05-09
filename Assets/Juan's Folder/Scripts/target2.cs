using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target2: MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
           // Score.scorevalue += 10;
            Destroy(gameObject);
        }
    }
}
