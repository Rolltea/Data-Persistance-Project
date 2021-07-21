using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class NameInput : MonoBehaviour
{
    public UnityEvent DoneSaving;
   public void SavePlayerName()
    {
        string playerName = GetComponent<TMP_InputField>().text;
        HighScoreManager.currentPlayerName = playerName;
        DoneSaving!.Invoke();
    }
}
