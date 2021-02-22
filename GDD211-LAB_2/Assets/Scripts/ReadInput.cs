using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour
{
    private string input;
    public GameObject panel;
    public Text user;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        user.text = input;
    }

    public void ReadStringInput(string x)
    {
        input = x;
        //if (Input.GetKey(KeyCode.Return))
        //{
        //    panel.SetActive(false);
        //}
        Debug.Log(input);
    }
}
