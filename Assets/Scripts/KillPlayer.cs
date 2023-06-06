using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KillPlayer : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, gameOver;
    public Transform respwanPoint;


    int lifeplayer;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        lifeplayer = 3;

        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (lifeplayer > 3)
            lifeplayer = 3;

        switch (lifeplayer) {

            case 3:

                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;

            case 2:

                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;

            case 1:

                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;

            case 0:

                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                gameOver.SetActive(true);
                Time.timeScale = 0f;
                break;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            lifeplayer = lifeplayer - 1;
            this.transform.position = respwanPoint.position;
        }

        if (lifeplayer == 0)
        {
            //Scene currentScene = SceneManager.GetActiveScene();
            //SceneManager.LoadScene(currentScene.name);
        }
    }
}