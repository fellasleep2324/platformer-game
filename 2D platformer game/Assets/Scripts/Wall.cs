using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Transform Watcher;
    public BoxCollider2D collider;
    public Transform vanish;

    void Update()
    {
        if(Watcher.position.x > vanish.position.x)
        {
            collider.enabled = false;
        }
    }
}
