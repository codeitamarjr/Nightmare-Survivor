using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorFinish : MonoBehaviour
{
/* Ontrigger when player Character enters the door, the game will load the next scene */
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("End Screen");
    }
}
