using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameTransfer : MonoBehaviour
{
    public string theName;
    public GameObject inputfield;
    public GameObject textDisplay;

    public void StoreName()
    {
        theName = inputfield.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = theName;

    }

}
