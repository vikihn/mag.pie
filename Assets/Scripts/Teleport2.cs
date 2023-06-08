using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport2 : MonoBehaviour
{

    public Transform Player;
    public Transform Target;
    public AudioSource teleportSound;

    // Start is called before the first frame update
    void Start()
    {

    }

    private bool entered;

    private void Update()
    {

        if (entered && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Pressed");
            Player.transform.position = Target.transform.position;
            teleportSound.Play();
        }

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            entered = true;
            Debug.Log("Entered the Collider");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            entered = false;
            Debug.Log("Left the Collider");
        }
    }

}