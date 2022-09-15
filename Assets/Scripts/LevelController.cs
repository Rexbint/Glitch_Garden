using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject loseLabel;
    [SerializeField] GameObject blocker;
    [SerializeField] int attackersCount;
    [SerializeField] float waitForLoad = 3f;
    bool levelTimerFinished = false;

    private void Start()
    {
        winLabel.SetActive(false);
        loseLabel.SetActive(false);
    }

    public void FindAttackersCount()
    {
        attackersCount++;
    }
    
    public void DecreseAttackersCount()
    {
        attackersCount--;
        if (attackersCount<=0 && levelTimerFinished)
        {
            StartCoroutine(HandleWinCondition());
        }
    }
    IEnumerator HandleWinCondition()
    {
        winLabel.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(waitForLoad);
        FindObjectOfType<LevelLoader>().LoadNextScene();
    }

    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner attackerSpawner in spawnerArray)
        attackerSpawner.StopSpawn();
    }

    public void Lose()
    {
        blocker.SetActive(true);
        loseLabel.SetActive(true);
        Time.timeScale = 0;
    }    
}
