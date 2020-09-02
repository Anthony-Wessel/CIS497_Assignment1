/*
 * Anthony Wessel
 * Assignment 1 Challenge
 * Check if plane is too high or low
 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOutOfBounds : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y > 80 || transform.position.y < -51) ScoreManager.gameover = true;
    }
}
