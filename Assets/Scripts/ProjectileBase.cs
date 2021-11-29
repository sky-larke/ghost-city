/*
 *  Author: Daniel, Isaac, Minseo.
 *  Class Description: Base class for all projectiles to inherit from.
 */
using UnityEngine;

[RequireComponent (typeof(Collider2D))]

public class ProjectileBase : MonoBehaviour
{
    //Possibly add animations to this script?
    public int Damage { get { return damage; } }  // set { damage = value; } }
    public Faction MyFaction { get { return myFaction; } set { myFaction = value; } }

    [SerializeField] protected Faction myFaction;
    [SerializeField] protected int damage;
    [SerializeField] protected float timeToDeath = 0f;

    protected Collider2D mCollider;

    private void Start()
    {
        mCollider = GetComponent<Collider2D>();
    }

    //delegate void OnDeath();

    protected void DeleteMe()
    {
        Destroy(gameObject); //this gameobject
    }
}
