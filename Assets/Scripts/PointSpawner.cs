using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawner : MonoBehaviour
{
    public GameObject[] pointsPrefabs;
    public static float spawnRate = 2f;
    // Start is called before the first frame update
    void Start()
    {
        spawnRate = 2f;
        InvokeRepeating("SpawnPoint", 1f, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnPoint()
    {
        if (Circle.itsOk)
        {
            Instantiate(pointsPrefabs[0], transform.position, Quaternion.identity);
            Instantiate(pointsPrefabs[1], transform.position, Quaternion.identity);
        }
    }
}
