using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Events;

public class HighScoreManager : MonoBehaviour
{
    public static HighScoreManager Instance;
    public static string currentPlayerName;
    public static string highScorePlayerName;
    public static int highScore;
    public UnityEvent DoneLoading;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(Instance);
        LoadHighScore();
    }

    private void Start()
    {
        DoneLoading!.Invoke();
    }

    public static void SaveHighScore(string playerName, int score)
    {
        HighScoreData data = new HighScoreData(playerName, score);
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/highscore.json", json);
    }

    public static void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/highscore.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            HighScoreData data = JsonUtility.FromJson<HighScoreData>(json);
            highScorePlayerName = data.playerName;
            highScore = data.score;
        }
    }
}
