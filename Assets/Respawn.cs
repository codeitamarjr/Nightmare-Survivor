using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform respawnPoint;
    
    // Update is called once per frame
    void Update()
    {
        // If the Player falls off the map, respawn them at the respawn point
        if(transform.position.y <= -5f){
            transform.position = respawnPoint.position;
        }
    }
}
