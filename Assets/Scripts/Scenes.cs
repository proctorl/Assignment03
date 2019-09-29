using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour {

    public void MainMenu()
    {
        SceneManager.LoadScene("Intro");
    }

    public void ExitGame()
    {

        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void HighScores()
    {
        SceneManager.LoadScene("HighScores");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Play");
    }

}
