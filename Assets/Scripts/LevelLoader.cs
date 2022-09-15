using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] int timeToWait = 4;
    int currentSceneIndex;


    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(Loader());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Loader()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex+1);
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene(3);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(currentSceneIndex);
        Time.timeScale = 1f;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("StartScreen");
        Time.timeScale = 1f;
    }

    public void Options()
    {
        SceneManager.LoadScene("Options Screen");
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
