/*
 * Jasmin Gonzalez
 * Prototype 1
 * Counter for crossing trigger zones
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach this to a trigger zone
public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
