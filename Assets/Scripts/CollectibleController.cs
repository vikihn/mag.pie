using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleController : MonoBehaviour
{
    private ScoreManager scoremanager;

    private void Start()
    {
        scoremanager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            scoremanager.score += 1f;
            Destroy(gameObject);
        }
    }
}
