using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    [SerializeField]
    int amount;

    void OnTriggerEnter2D(Collider2D collider)
    {
        GameManager gameManager = FindObjectOfType<GameManager>();

        if (gameManager != null)
        {
            gameManager.AddScore(amount);
        }
        else
        {
            Debug.LogWarning("GameManager not found!");
        }
    }
}
