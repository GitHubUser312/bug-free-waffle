using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text scoreText = null;

    private static GameManager instance = null;

    private int score = 0;
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Update()
    {

    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreToDisplay();
    }

    private void UpdateScoreToDisplay()
    {
        scoreText.text = score.ToString();
    }
}
