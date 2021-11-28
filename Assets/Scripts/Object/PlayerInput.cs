using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Movement myMovement;
    public float xSpeed;
    public float ySpeed;
    private Rigidbody2D myRigidbody2D ;
    // Start is called before the first frame update
    void Start()
    {
        myMovement = GetComponent<Movement>();
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            myMovement.MoveY(ySpeed * Time.deltaTime);
            //myRigidbody2D.velocity = new Vector3(0, 1, 0);
        }
        /*if (Input.GetKey(KeyCode.S))
        {
            myMovement.MoveY(-ySpeed * Time.deltaTime);
        }*/
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
