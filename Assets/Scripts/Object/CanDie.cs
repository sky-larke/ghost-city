using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanDie : MonoBehaviour
{
    private Attackable myAttackable;
    // Start is called before the first frame update
    void Start()
    {
        myAttackable = GetComponent<Attackable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myAttackable.GetHealth() < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
