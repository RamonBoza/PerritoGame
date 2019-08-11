using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void OptionsButton()
    {
        SceneManager.LoadScene("OptionsScene");
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void ReturnButton()
    {
        SceneManager.LoadScene("MainScene");
    }
}
