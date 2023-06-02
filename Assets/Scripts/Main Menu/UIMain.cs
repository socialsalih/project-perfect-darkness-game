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
    public void LevelTwo()
    {
        Application.LoadLevel("1-2");
    }
    public void LevelThree()
    {
        Application.LoadLevel("1-3");
    }
    public void LevelFour()
    {
        Application.LoadLevel("1-4");
    }
    public void LevelFive()
    {
        Application.LoadLevel("1-5");
    }
    public void LevelSix()
    {
        Application.LoadLevel("2-1");
    }
    public void LevelSeven()
    {
        Application.LoadLevel("2-2");
    }
    public void LevelEight()
    {
        Application.LoadLevel("2-3");
    }
    public void LevelNine()
    {
        Application.LoadLevel("2-4");
    }
    public void LevelTen()
    {
        Application.LoadLevel("2-5");
    }
    public void LevelEleven()
    {
        Application.LoadLevel("3-1");
    }
    public void LevelTwelve()
    {
        Application.LoadLevel("3-2");
    }
    public void LevelThirteen()
    {
        Application.LoadLevel("3-3");
    }
    public void LevelFourteen()
    {
        Application.LoadLevel("3-4");
    }
    public void LevelFifteen()
    {
        Application.LoadLevel("3-5");
    }
    public void LevelSixteen()
    {
        Application.LoadLevel("4-1");
    }
    public void LevelSeventeen()
    {
        Application.LoadLevel("4-2");
    }
    public void LevelEighteen()
    {
        Application.LoadLevel("4-3");
    }
    public void LevelNineteen()
    {
        Application.LoadLevel("4-4");
    }
    public void LevelTwenty()
    {
        Application.LoadLevel("4-5");
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