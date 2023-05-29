using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform Player;
    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

private bool entered;

private void Update()
    {

        if (entered && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Pressed");
            Player.transform.position = Target.transform.position;
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