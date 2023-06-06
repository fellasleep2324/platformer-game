using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene3CutsceneLoader : MonoBehaviour
{
    public Transform player;
public void cutsceneloader()
    {
     if (player.position.x > transform.position.x)
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
