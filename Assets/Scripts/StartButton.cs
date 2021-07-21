using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class StartButton : MonoBehaviour
{
    public UnityEvent StartGame;
   
    public void ChangeScene()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PressStart()
    {
        StartGame!.Invoke();
    }
}
