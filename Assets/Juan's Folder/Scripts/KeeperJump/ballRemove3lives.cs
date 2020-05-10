using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballRemove3lives : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        livesOnly3forSub.health -= 1;
    }
}
