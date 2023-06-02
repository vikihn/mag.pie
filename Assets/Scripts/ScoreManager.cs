using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text textscore;
    public float score;
    public GameObject gameWon;

    // Start is called before the first frame update
    void Start()
    {
        score = 0f;
        gameWon.SetActive(false);
        textscore.text = score.ToString() + " Valuables";
    }

    // Update is called once per frame
    void Update()
    {
        textscore.text = score.ToString() + " Valuables";

        if (score == 14)
        {
            gameWon.SetActive(true);
        }
    }
}