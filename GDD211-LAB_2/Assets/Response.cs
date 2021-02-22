using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Response : MonoBehaviour
{
    public string response;
    public GameObject inputField;
    public GameObject textDisplay;

    public void storeResponse()
    {
        response = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = response;
    }
}
