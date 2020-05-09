using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackEyeBallRemove : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        blackEyes8Lives.health -= 1;
    }
}

