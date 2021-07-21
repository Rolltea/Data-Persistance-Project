using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartHighScoreText : MonoBehaviour
{
    TextMeshProUGUI tmpUGUI;
    private void Awake()
    {
        tmpUGUI = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateHighscoreText()
    {
        tmpUGUI.text = "Best Score : " + HighScoreManager.highScorePlayerName + " : " + HighScoreManager.highScore;
    }
}
