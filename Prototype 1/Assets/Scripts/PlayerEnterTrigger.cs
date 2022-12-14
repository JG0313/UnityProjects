/*
 * Jasmin Gonzalez
 * Prototype 1
 * Manages trigger zones
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//attach this to player

public class PlayerEnterTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
}
