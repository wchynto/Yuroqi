using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject gameOverPanel, transparentPanel, pauseButton; 
    public TextMeshProUGUI gameStatus;

    public void LevelComplete(){

        gameStatus.text = "Level Completed";
        gameOverPanel.SetActive(true);
        transparentPanel.SetActive(true);
        pauseButton.SetActive(false);
    }

}
