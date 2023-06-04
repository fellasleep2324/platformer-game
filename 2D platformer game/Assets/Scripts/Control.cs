using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject MainGame;
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }

    public void whenButtonClicked()
    {
        Canvas.SetActive(false);
        MainGame.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
