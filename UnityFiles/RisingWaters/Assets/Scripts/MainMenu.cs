﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneIndex;
    private PlayerController player;

    public void Start()
    {
        player = FindObjectOfType<PlayerController>();
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void PlayEndless()
    {
        SceneManager.LoadScene("Endless");
    }

    public void ArcadeMsg()
    {
        SceneManager.LoadScene("ArcadeMsg");
    }

    public void SettingsMenu()
    {
        SceneManager.LoadScene("SettingsMenu");
    }

    public void MenuMain()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene(sceneIndex - 1);
    }
    

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Player hits an obstacle
        if (collision.CompareTag("Player"))
        {
            LoadNextLevel();
        }
    }


    //public void GameOver()
    //{
    //    //Scene deathScene = SceneManager.GetActiveScene();
        
    //    SceneManager.LoadScene("GameOver");
    //}

    public void Restart()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
