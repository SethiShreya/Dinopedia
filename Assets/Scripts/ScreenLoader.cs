using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenLoader : MonoBehaviour
{
    public void loadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void loadARScene()
    {
        SceneManager.LoadScene("ARScene");
    }

    public void quitScreen()
    {
        Application.Quit();
    }

}
