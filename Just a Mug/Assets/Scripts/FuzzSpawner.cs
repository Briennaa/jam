using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuzzSpawner : MonoBehaviour
{

    // Prefab to spawn
    public GameObject spawnee;
    public GameObject speedySpawnee;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
        StartCoroutine(SpeedySpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(SpawnTimer.getSpawnTimer());
        }
    }

    IEnumerator SpeedySpawner()
    {
        while (true)
        {
            SpawnSpeedy();
            yield return new WaitForSeconds(SpawnTimer.getSpawnTimer() + 5);
        }
    }

    void Spawn()
    {
        if (Pause.getPaused() == false)
        {
            float rightScreenBound = 5;                    // set value for this
            float leftScreenBound = -5;                    // set value for this
            float randomY = Random.Range(-10f, 0f);
            float randomSide = Random.Range(0f, 3f);

            if (randomSide < 1)
            {
                Instantiate(spawnee, new Vector3(rightScreenBound, randomY, 0), Quaternion.identity);
            }
            else if (randomSide >= 1 && randomSide < 2)
            {
                Instantiate(spawnee, new Vector3(leftScreenBound, randomY, 0), Quaternion.identity);
            }
            else if (randomSide >= 2)
            {
                //they come from the bottom
                float randomX = Random.Range(-10f, 10f);
                Instantiate(spawnee, new Vector3(randomX, -7, 0), Quaternion.identity);
            }
        }
    }

    void SpawnSpeedy()
    {
        if (Pause.getPaused() == false && SpawnTimer.getSpawnTimer() < 1.90)
        {
            //they come from the bottom
            float randomX = Random.Range(-5f, 5f);
            Instantiate(speedySpawnee, new Vector3(randomX, -7, 0), Quaternion.identity);
        }
    }
}
