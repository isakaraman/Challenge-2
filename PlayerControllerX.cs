using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float spawnTimer=0;
    // Update is called once per frame
    void Update()
    {

        // On spacebar press, send dog
        spawnTimer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (spawnTimer >= 2)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                spawnTimer = 0;
            }
    
        }

    }
}
