using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Start()
    {

    }

    public void RestartButton()
    {

        SceneManager.LoadScene(0);
    }
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }

   
}
