using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager manager = GameObject.FindObjectOfType<GameManager>();

        manager.AddScore(2);
        Destroy(gameObject);
    }
}
