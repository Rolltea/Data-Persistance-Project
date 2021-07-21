using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainHighScoreText : MonoBehaviour
{
    Text highScoreText;
    private void Awake()
    {
         highScoreText = GetComponent<Text>();
    }
    public void UpdateHighscoreText()
    {
         highScoreText.text = "Best Score : " + HighScoreManager.highScorePlayerName + " : " + HighScoreManager.highScore;
    }
}
