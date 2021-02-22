using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public string user;
    public Text tellPlayer;
    // Start is called before the first frame update

    void Awake()
    {
        user = PlayerPrefs.GetString("User", user);
        tellPlayer.text = "Hi " + user;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
