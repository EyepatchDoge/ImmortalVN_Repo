﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void NewScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("You have left the game.");
        }
    }

    public void QuitTheGame()
    {
        Application.Quit();
        Debug.Log("Quit has been sucessful");
    }
}
