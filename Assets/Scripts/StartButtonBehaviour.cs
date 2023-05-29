using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonBehaviour : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Environment";

    public void StartButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
