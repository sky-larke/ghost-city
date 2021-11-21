using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Movement myMovement;
    public float xSpeed;
    public float ySpeed;
    // Start is called before the first frame update
    void Start()
    {
        myMovement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            myMovement.MoveY(ySpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            myMovement.MoveY(-ySpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            myMovement.MoveX(-xSpeed* Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            myMovement.MoveX(xSpeed * Time.deltaTime);
        }
    }
}
