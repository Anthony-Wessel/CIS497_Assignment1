using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour
{
    public static int score;
    public static bool gameOver;
    bool won;
    public Text text;

    private void Start()
    {
        score = 0;
        gameOver = false;
        won = false;
    }

    public void Update()
    {
        if (!gameOver)
        {
            text.text = "Score: " + score;
        }

        if (score >= 3)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                text.text = "You win!\n"
                    + "Press R to play again!";
            }
            else
            {
                text.text = "You lose!\n"
                    + "Press R to try again!";
            }

            if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(0);
        }
        

    }
}
