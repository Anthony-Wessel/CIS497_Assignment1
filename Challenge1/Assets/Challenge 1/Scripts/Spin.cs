/*
 * Anthony Wessel
 * Assignment 1 Challenge
 * Spin the propeller
 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.forward, Time.deltaTime * rotationSpeed);
    }
}
