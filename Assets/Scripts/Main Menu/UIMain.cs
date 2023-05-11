using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMain : MonoBehaviour
{
    [Header("UIPages")]
    public GameObject settingsScreen;
    public GameObject mainScreen;
    public GameObject levelScreen;
    public GameObject creditScreen;

    public void StartGame()
    {
        Application.LoadLevel("1-1");
    }
    public void Settings()
    {
        mainScreen.SetActive(false);
        settingsScreen.SetActive(true);
    }
    public void Levels()
    {
        mainScreen.SetActive(false);
        levelScreen.SetActive(true);
    }
    public void LevelOne()
    {
        Application.LoadLevel("1-1");
    }
    public void Credits()
    {
        mainScreen.SetActive(false);
        creditScreen.SetActive(true);
    }

    public void set2Menu()
    {
        mainScreen.SetActive(true);
        settingsScreen.SetActive(false);
    }
    public void lev2Menu()
    {
        mainScreen.SetActive(true);
        levelScreen.SetActive(false);
    }
    public void cre2Menu()
    {
        mainScreen.SetActive(true);
        creditScreen.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        Application.LoadLevel("Main Menu");
    }
}