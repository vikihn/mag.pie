using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpText : MonoBehaviour
{
    public GameObject popUpText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Replace "Player" with the tag of your player object
        {
            popUpText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Replace "Player" with the tag of your player object
        {
            popUpText.SetActive(false);
        }
    }
}
