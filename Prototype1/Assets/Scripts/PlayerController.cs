/*
 * Anthony Wessel
 * Assignment 1 prototype
 * Controls player movement
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    float horizontalInput;
    float forwardInput;

    // Update is called once per frame
    void Update()
    {
        if (!ScoreManager.gameOver)
        {
            horizontalInput = Input.GetAxisRaw("Horizontal");
            forwardInput = Input.GetAxisRaw("Vertical");

            transform.Translate(Vector3.forward * forwardInput * speed * Time.deltaTime);
            transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);
        }
        
    }
}
