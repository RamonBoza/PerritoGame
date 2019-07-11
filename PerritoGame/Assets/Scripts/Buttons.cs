using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
