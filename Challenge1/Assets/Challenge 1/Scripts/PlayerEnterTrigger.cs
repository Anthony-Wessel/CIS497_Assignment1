/*
 * Anthony Wessel
 * Assignment 1 Challenge
 * Increment score when plane passes through a wall
 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnterTrigger : MonoBehaviour
{

    bool triggered;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        triggered = false;
    }
}
