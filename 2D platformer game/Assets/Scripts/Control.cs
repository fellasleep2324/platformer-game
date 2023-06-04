using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public GameObject Canvas;
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
    
    public void whenButtonClicked()
    {
        if (Canvas.activeInHierarchy == true)
            Canvas.SetActive(false);
        else
            Canvas.SetActive(true);
    }    
    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
