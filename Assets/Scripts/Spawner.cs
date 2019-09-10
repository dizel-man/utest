using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject obj;
    public int numberOfFlower = 10;
    public float spawnRadius = 5.0f;
    private Vector3 spawnPosition;
    [Space(5)]
    public float Up = 0;

    
    void Start()
    {
        FlowerSpawn();
    }

    
    void Update()
    {
        
    }

    void FlowerSpawn()
    {
        for (int i = 0; i < numberOfFlower; i++)
        {
            spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            Vector3 adjustedPos = new Vector3(spawnPosition.x, Up, spawnPosition.z);
            Instantiate(obj, adjustedPos, Quaternion.identity);
        }
    }
}
