using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//We have our goalkeeper that has an animator and then 2 child empy game objects. they are infront of the ball, 
//one on the left and one on the right, they each have one collider that is trigger.
//Each child object also has a script, this script is one, the other 'JumpRight' is for the other game object.
//This script is to make the keeper dive when the ball goes through the collider thus playing the appropiate animation.

public class JumpLeft : MonoBehaviour
{
    public void OnTriggerEnter(Collider oi) 
    {
        
        if (oi.CompareTag("Keeper")) //ball needs to have the tag keeper or whatever you want instead, super important. incase doesnt work make object the scripts attached to have the tag keeper
        {          
            GetComponentInParent<Animator>().SetTrigger("KeeperDiveLeft");  //calls the animator from the parent object (the goalkeeper) and set the trigger to keeper dive left. **       
            //Debug.Log("Nothing");
        }

    }
}

//**  the trigers can be found on the Animator<parameters<you have two different triggers one move left and one move right
//The Jumpright scrip[t works the same way just applied to the other child and the trigger is dive right