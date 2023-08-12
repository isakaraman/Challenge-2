﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -27;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 31;

    private float startDelay = 3f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY,0);

        // instantiate ball at random spawn location
        int RandomBall = Random.Range(0,3);
        Instantiate(ballPrefabs[RandomBall], spawnPos, ballPrefabs[0].transform.rotation);

        startDelay = Random.Range(3, 6);
    }

}