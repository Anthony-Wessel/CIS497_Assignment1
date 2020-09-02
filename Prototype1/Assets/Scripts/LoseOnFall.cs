/*
 * Anthony Wessel
 * Assignment 1 prototype
 * Lose if player falls off road
 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseOnFall : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1) ScoreManager.gameOver = true;
    }
}
