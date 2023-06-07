using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource footstepsSound, jumpSound;

    private void Start()
    {
        jumpSound.enabled = true;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) ||
            Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            footstepsSound.enabled = true;
        }

        
        else
        {
            footstepsSound.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            footstepsSound.enabled = false;
            jumpSound.Play();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            footstepsSound.enabled = false;
            //jumpSound.Play();
        }

        /*
        else
        {
            jumpSound.enabled = false;
        }
        */

        if (Time.timeScale == 0f)
        {
            jumpSound.enabled = false;
            footstepsSound.enabled = false;
        }
    }
}
