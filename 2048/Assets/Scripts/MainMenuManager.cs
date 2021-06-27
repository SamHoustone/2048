using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void Game()
    {
        SceneManager.LoadScene(1);
    }
    public void GameExit()
    {
        Application.Quit();
    }
}
