/*
 * Jasmin Gonzalez
 * Prototype 1
 * Keeps score and determines end of game
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    //Notice public static variables can accessed from any script
    //but cannot be seen in the Inspector

    public static bool gameOver;
    public static bool won;
    public static int score;

    //Set this in the Inspector
    public Text textbox;

    private void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        //If the game is not over, display score
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }
        //win condition:3 or more points
        if (score >= 3)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You win!!\nPress R to Try Again!";
            }
            else
            {
                textbox.text = "You lose!\nPress R to Try Again!";
            }
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
