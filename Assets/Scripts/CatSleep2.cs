using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSleep2 : MonoBehaviour
{
    public static bool sleep2;
    float sleepduration;
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
                sleepduration = 3f;
                GetComponent<Animator>().SetBool("Sleep2", false);
                GetComponent<CapsuleCollider2D>().enabled = true;
                GetComponent<Rigidbody2D>().gravityScale = 1.8f;
            }
        }
    }
}
