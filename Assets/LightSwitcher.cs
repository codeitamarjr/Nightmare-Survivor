using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitcher : MonoBehaviour
{
    public Light myLight;

    void MyFunction()
    {
        myLight.enabled = !myLight.enabled;
    }

    public void LightFlash()
    {
        myLight.enabled = true;
        Invoke("MyFunction", 0.5f);
        myLight.enabled = false;
    }
    
    // Start is called before the first frame update
    // void Start()
    // {
    // }

    // Update is called once per frame
    void Update()
    {

        LightFlash();
        // Action to trigger the function
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MyFunction();
        }
    }
}
