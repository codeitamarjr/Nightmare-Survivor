using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour

{

    public int damagePerHit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

/* When the enemy collides with another object, it will print the name of the object it collided with */
     void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enemy has collided with " + other.name);
        /* Reduces 1 health from the player per second */
        if (other.name == "Character")
        {
            other.GetComponent<Player>().TakeDamage(damagePerHit);
        }
    }
}
