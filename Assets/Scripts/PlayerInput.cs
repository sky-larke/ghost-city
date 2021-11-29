/*
 *  Author: Minseo
 *  Class Description: Checks key inputs and moves the player.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    private Movement myMovement; //Reference to script that moves the player.
    [Tooltip ("Speed of the object in X direction")]
    [SerializeField] private float xSpeed;
    [Tooltip("Speed of the object in Y direction")]
    [SerializeField] private float ySpeed;

    [SerializeField] private GameObject myProjectile;


    // Start is called before the first frame update
    void Start()
    {
        myMovement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(myProjectile, this.transform.position, Quaternion.identity);
        }
    }
}
