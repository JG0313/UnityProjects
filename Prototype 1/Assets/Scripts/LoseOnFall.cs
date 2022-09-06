/*
 * Jasmin Gonzalez
 * Prototype 1
 * Outputs loss when falling off the road
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoseOnFall : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Check Loss condition
        if (transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
