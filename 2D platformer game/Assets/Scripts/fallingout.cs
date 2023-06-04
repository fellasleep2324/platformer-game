using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fallingout : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject MainGame;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
            Canvas.SetActive(true);
            MainGame.SetActive(false);
    }
}
