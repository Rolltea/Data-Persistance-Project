using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreData
{
    public string playerName;
    public int score;

    public HighScoreData(string playerName, int score)
        {
            this.playerName = playerName;
            this.score = score;
        }
}
