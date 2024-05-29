using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScenes : MonoBehaviour
{
    public void Awake()
    {
        Time.timeScale = 0f;
    }
    public void ChangeToGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
