using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 1f;
    private float spawnTime = 0f;

    public GameObject HexaPref;

    void Update()
    {
        if(Time.time >= spawnTime)
        {
            Instantiate(HexaPref);
            spawnTime = Time.time + 1f / spawnRate;
        }
    }
}
