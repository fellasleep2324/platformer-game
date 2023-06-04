using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverOn_Off : MonoBehaviour
{
    private Light myLight;
    void Start()
    {
        myLight = GetComponent<Light>();    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}
