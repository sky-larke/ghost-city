/*
 *  Author: Minseo
 *  Class Description: Handles moving based on inputs of called functions
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D myRB;

    private void Start()
    {
        
    }

    public void MoveY(float input)
    { // Move the object up and down by the input .
        Debug.Log("Attempt transform, input is" + input);
        this.transform.position += Vector3.up * input;
    }

    public void MoveX(float input)
    {//Move the object left and right by the input
        this.transform.position += Vector3.right * input;
    }
}
