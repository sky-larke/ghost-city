using UnityEngine;

public enum Faction {PLAYER, ENEMY, NEUTRAL, DEFAULT};

public class Attackable : MonoBehaviour
{
    public float Health { get { return health; } }
    public Faction MyFaction { get { return myFaction; } }

    [SerializeField] protected Faction myFaction;
    [SerializeField] private float health;

    public void ChangeHealth(float change)
    {
        health += change;
    }

    public void SetHealth(float toSet)
    {
        health = toSet;
    }

}
