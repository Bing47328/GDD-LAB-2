using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radius : MonoBehaviour
{
    public GameObject input;
    public GameObject playerText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            input.SetActive(true);
            playerText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        input.SetActive(false);
        playerText.SetActive(false);
    }
}
