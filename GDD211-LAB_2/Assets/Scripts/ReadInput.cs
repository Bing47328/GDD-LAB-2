using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReadInput : MonoBehaviour
{
    public InputField input;
    private string user;

    public GameObject panel;

    public void SetUser() 
    {
        user = input.text;
        PlayerPrefs.SetString("User", user);
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("Lab_2 1");
        }

    }
}
