using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotItButtonBehaviour : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Environment";

    public void GotItButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
