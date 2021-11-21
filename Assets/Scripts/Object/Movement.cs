using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public void MoveY(float input)
    { // Move the object up and down by the input .
        Debug.Log("Attempt transform, input is" + input);
        this.transform.position += new Vector3(0,input,0);
    }

    public void MoveX(float input)
    {//Move the object left and right by the input
        this.transform.position += new Vector3(input, 0, 0);
    }
}
