using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerEnter : MonoBehaviour
{
    bool triggered;

    private void Start()
    {
        triggered = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            ScoreManager.score++;
            triggered = true;
        }
    }
}
