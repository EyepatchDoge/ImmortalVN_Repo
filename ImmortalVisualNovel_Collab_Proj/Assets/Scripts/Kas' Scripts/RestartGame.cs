using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour
{
    public GameObject mcPanel;
    public GameObject narrativePanel;
    public GameObject otherPanel;
    public GameObject lowerNarrativePanel;
    public GameObject momPanel;


    public void NewScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("You have left the game.");
        }*/
    }

    public void QuitTheGame()
    {
        Application.Quit();
        Debug.Log("Quit has been sucessful");
    }

    public void PauseGame()
    {
       /* momPanel.SetActive(false);
        mcPanel.SetActive(false);
        otherPanel.SetActive(false);
        narrativePanel.SetActive(false);
        lowerNarrativePanel.SetActive(false);*/
        
       Time.timeScale = 0;
        Debug.Log("Game is paused");
    }

    public void ResumeGame()
    {
        /*momPanel.SetActive(true);
        mcPanel.SetActive(true);
        otherPanel.SetActive(true);
        narrativePanel.SetActive(true);
        lowerNarrativePanel.SetActive(true);*/
        Time.timeScale = 1;
         Debug.Log("Game has resumed");
    }

   
}
