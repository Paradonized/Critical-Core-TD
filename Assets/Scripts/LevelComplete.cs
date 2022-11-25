using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public SceneFader sceneFader;
    public string menuSceneName = "MainMenu";
    public string nextLevel = "Level 2";
    public int unlockLevel = 2;
    public void Continue()
    {
        PlayerPrefs.SetInt("levelReached", unlockLevel);
        sceneFader.FadeTo(nextLevel);
    }
    public void Menu()
    {
        PlayerPrefs.SetInt("levelReached", unlockLevel);
        sceneFader.FadeTo(menuSceneName);
    }
}
