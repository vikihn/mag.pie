using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSleep2 : MonoBehaviour
{
    public static bool sleep2;
    float sleepduration;

    public AudioSource purr;
    public float cooldowntime = 4f;
    private bool inCooldown;
    private IEnumerator Cooldown()
    {
        //Set the cooldown flag to true, wait for the cooldown time to pass, then turn the flag to false
        inCooldown = true;
        yield return new WaitForSeconds(cooldowntime);
        inCooldown = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !inCooldown)
        {
            purr.Play();
            Debug.Log("in Cooldown");

            StartCoroutine(Cooldown());
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        sleepduration = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        if(sleep2)
        {
            sleepduration = sleepduration - Time.deltaTime;
            GetComponent<Animator>().SetBool("Sleep2", true);
            GetComponent<CapsuleCollider2D>().enabled = false;
            GetComponent<Rigidbody2D>().gravityScale = 0;
            if (sleepduration <= 0f)
            {
                sleep2 = false;
                sleepduration = 4f;
                GetComponent<Animator>().SetBool("Sleep2", false);
                GetComponent<CapsuleCollider2D>().enabled = true;
                GetComponent<Rigidbody2D>().gravityScale = 0f;
            }
        }
    }
}
