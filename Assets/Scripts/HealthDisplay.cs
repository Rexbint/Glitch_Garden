using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] public int healthPoints = 100;
    Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>();
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        healthText.text = healthPoints.ToString();
    }

    public void DecreaseHealth(int amount)
    {
        healthPoints -= amount;
        UpdateHealth();
        if(healthPoints<=0)
        {
            FindObjectOfType<LevelController>().Lose();
        }
    }
}
