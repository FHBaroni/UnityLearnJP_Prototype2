using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    private float startDelay = 2f;
    private float spawnInterval = 2.2f;
    private float spawnRangeX = 10;
    private float spawnPosZ = 20;
    private float spawnPosRightX = 25;
    private float spawnPosLeftX = -25;
    private float spawnRangeTop = 15;
    private float spawnRangeBottom = -1;

    void Start()
    {       
        InvokeRepeating("SpawnRandomObject", startDelay, spawnInterval);
    }

    void Update()
    {

    }

    void SpawnRandomObject()
    {
        int objectIndex = Random.Range(0, itemPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(itemPrefabs[objectIndex], spawnPos, itemPrefabs[objectIndex].transform.rotation);

        if (Random.value < 0.5f)
        {
            int objectIndex2 = Random.Range(0, itemPrefabs.Length);
            Vector3 spawnPos2 = new Vector3(spawnPosRightX, 0, Random.Range(spawnRangeBottom, spawnRangeTop));
            GameObject rightAnimal = Instantiate(itemPrefabs[objectIndex2], spawnPos2, itemPrefabs[objectIndex2].transform.rotation);
            rightAnimal.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else
        {
            int objectIndex3 = Random.Range(0, itemPrefabs.Length);
            Vector3 spawnPos3 = new Vector3(spawnPosLeftX, 0, Random.Range(spawnRangeBottom, spawnRangeTop));
            GameObject leftAnimal = Instantiate(itemPrefabs[objectIndex3], spawnPos3, itemPrefabs[objectIndex3].transform.rotation);
            leftAnimal.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }
}
