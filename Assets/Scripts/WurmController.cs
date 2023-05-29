using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WurmController : MonoBehaviour
{
 

    private void Start()
    {
     
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
