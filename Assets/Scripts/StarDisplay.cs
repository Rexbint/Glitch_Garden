using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text starText;

    // Start is called before the first frame update
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateText();
    }

    private void UpdateText()
    {
        starText.text = stars.ToString();
    }

    public bool HaveEnoughStars(int amount)
    {
        return stars >= amount;
    }

    public void AddStars(int amountStars)
    {
        stars += amountStars;
        UpdateText();
    }

    public void DecreaseStars(int amountOfDecrease)
    {
        if (stars >= amountOfDecrease)
        {
            stars -= amountOfDecrease;
            UpdateText();
        }
    }
}
