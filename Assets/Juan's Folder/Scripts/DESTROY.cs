﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DESTROY : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Target")
        {
            Destroy(other.gameObject); // this destroys the enemy
            //Destroy(gameObject); // this destroys the bullet
        }
    }
}
