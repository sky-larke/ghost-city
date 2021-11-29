/*
 *  Author: Daniel, Isaac, Minseo.
 *  Class Description: Simple script that has projectile move in a straight line
 */
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class SimpleProjectile : ProjectileBase
{
    //Possibly add animations to this script?

    [SerializeField] private float speed = 1f;

    private Rigidbody2D mRigidbody;

    private void Start()
    {
        mRigidbody = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        Debug.Log("mspeed " + speed);
        mRigidbody.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Attackable colid = collision.GetComponent<Attackable>();
        if (colid != null)
        {
            if (colid.MyFaction != myFaction)
            {
                colid.ChangeHealth(-damage);
                Invoke("DeleteMe", timeToDeath);
            }
            Debug.Log("I hit something with attackable");
        }
        else
        {
            Debug.Log("I hit something");
            Invoke("DeleteMe", timeToDeath);
        }
    }
}
