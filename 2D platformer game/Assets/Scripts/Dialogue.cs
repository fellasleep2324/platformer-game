using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    
    public TestMeshProUGUI textDisplay
    public string[] sentences;
    private int index; 
    public float typingSpeed;

    void start(){
    StartCoroutine(Type());
    }
    
    IEnumerator Type(){

        foreach(char letter in sentences[index].ToCharArray())
        textDisplay.text += letter;
        yield return new WaitForSeconds(0.02f);
    }

}
