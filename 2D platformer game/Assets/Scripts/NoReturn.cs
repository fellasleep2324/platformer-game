using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoReturn : MonoBehaviour
{
    public Transform Begin;
    public Rigidbody2D rigidbody;
    public Transform Player;

    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        if(Player.position.y > Begin.position.y)
        {
         rigidbody.constraints = RigidbodyConstraints2D.None;
        }
    }
}
