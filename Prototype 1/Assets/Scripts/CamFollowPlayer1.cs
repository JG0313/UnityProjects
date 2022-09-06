/*
 * Jasmin Gonzalez
 * Prototype 1
 * Connects camera to the Player Object
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    //drag the player onto this reference in
    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -10);

    //Update is called once per frame

    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
