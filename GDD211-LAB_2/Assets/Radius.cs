using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radius : MonoBehaviour
{
    public GameObject input;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            input.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        input.SetActive(false);
    }
}
