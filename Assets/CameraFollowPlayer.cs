using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{

    public Transform player;

    // Update is called once per frame
    void Update()
    {
        // Follow the player's position from the third person perspective ( 6, 9, -7)
        transform.position = player.position + new Vector3(6, 9, -7);
        // Follow the player's rotation from the third person perspective ( 6, 9, -7)
        //transform.rotation = player.rotation;        
    }
}
