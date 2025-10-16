using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private float lifetime = 3f; // Duration in seconds before destroying

    [SerializeField]
    GameObject Object;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= lifetime)
        {
            Instantiate(Object, transform.position, Quaternion.identity);
            timer = 0f;
        }
    }
}
