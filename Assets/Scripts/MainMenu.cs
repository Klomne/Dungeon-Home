using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public bool isStart;
    public bool isRestart;
    public bool isQuit;

    public void ChangeLevel()
    {
        if (isStart)
        {
            SceneManager.LoadScene("Game");
        }
        if (isRestart)
        {
            SceneManager.LoadScene("Game");
        }
        if (isQuit) 
        { 
            Application.Quit();
        }
    }
}
