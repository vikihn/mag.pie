using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToTitleButtonBehaviour : MonoBehaviour
{
    [SerializeField] private string loadTitleScreen = "StartScreen";

    public void BackToTitleButton()
    {
        SceneManager.LoadScene(loadTitleScreen);
    }
}