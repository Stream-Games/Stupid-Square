using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public void StartMenu()
    {
    	SceneManager.LoadScene("Start");
    }

    public void Play()
    {
    	SceneManager.LoadScene(1);
    }

    public void LoadLevels()
    {
    	SceneManager.LoadScene("Levels");
    }

    public void End()
    {
    	SceneManager.LoadScene("End");
    }

    public void ReloadScene()
    {
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadNextLevel()
    {
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
