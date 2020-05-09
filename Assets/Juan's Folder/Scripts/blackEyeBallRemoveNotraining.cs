using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackEyeBallRemoveNotraining : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       blackEye4Lives.health -= 1;
    }
}
