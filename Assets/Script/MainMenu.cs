using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("StageMenu");
    }

    public void GoToSettingsMenu()
    {
        SceneManager.LoadScene("SettingsMenu");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToStage1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GoToStage2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void GoToStage3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void QuitGame()
    {
        Application.Quit(); 
    }
}
