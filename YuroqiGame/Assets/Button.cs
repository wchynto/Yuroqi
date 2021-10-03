using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    public GameObject gameOverPanel, transparentPanel, pauseButton;

    public void ChangesScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void PauseGame()
    {   
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
        transparentPanel.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void PlayGame()
    {
        Time.timeScale = 1;
        gameOverPanel.SetActive(false);
        transparentPanel.SetActive(false);
        pauseButton.SetActive(true);
    }
}
