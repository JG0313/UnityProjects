using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -50 || transform.position.y > 80)
        {
            ScoreManager.gameOver = true;
        } 
    }
}
