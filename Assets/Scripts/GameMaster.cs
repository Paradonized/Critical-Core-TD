using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public static bool GameIsOver;
    public static bool LevelIsWon;
    public GameObject gameOverUI;
    public GameObject completeLevelUI;
    public string nextLevel = "Level 2";
    public int unlockLevel = 2;
    void Start()
    {
        GameIsOver = false;
        LevelIsWon = false;
    }
    void Update()
    {
        if (PlayerStats.Lives <= 0 && LevelIsWon)
        {
            EndGame();
            if (GameIsOver)
            {
                return;
            }
        }
    }
    void EndGame()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);
    }
    public void WinLevel()
    {
        GameIsOver = true;
        completeLevelUI.SetActive(true);
    }
}
