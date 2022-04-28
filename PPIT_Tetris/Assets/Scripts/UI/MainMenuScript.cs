using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void startFunction()
    {
        SceneManager.LoadScene(1);
    }

    public void optionsFunction()
    {
        SceneManager.LoadScene(2);
    }

    public void menueFunction()
    {
        SceneManager.LoadScene(0);
    }

    public void quitFunction()
    {
        Application.Quit();
    }

}
