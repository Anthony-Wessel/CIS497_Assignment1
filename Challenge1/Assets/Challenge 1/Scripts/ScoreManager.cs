/*
 * Anthony Wessel
 * Assignment 1 Challenge
 * Manage the score and UI
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public static bool gameover;
    bool won;

    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gameover = false;
        won = false;
    }

    // Update is called once per frame
    void Update()
    {
        // End game if player has won
        if (score >= 5)
        {
            won = true;
            gameover = true;
        }

        // Update score while game is still going
        if (!gameover)
        {
            text.text = "Score: " + score;
        }
        else // Game has already ended
        {
            if (won)
            {
                text.text = "You won!\n"
                    + "Press R to play again";
            }
            else
            {
                text.text = "You lost!\n"
                    + "Press R to try again";
            }
            if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(0);
        }
    }
}
