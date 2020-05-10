using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpRight : MonoBehaviour
{
    public SwipeScript swipe;

    public void OnTriggerEnter(Collider oi)
    {

        if (oi.CompareTag("Keeper"))
        {

            GetComponentInParent<Animator>().SetTrigger("KeeperRight");
            
            Debug.Log("Nothing");

        }

    }
}