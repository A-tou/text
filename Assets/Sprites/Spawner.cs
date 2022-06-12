using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnTime = 5f;        // The amount of time between each spawn.
    public float spawnDelay = 3f;
    // Start is called before the first frame update
    public GameObject[] enemies;
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnDelay, spawnTime);
    }

    void SpawnEnemy()
    {
        int index = Random.Range(0,1);
        Instantiate(enemies[index], transform.position, transform.rotation);
        foreach (ParticleSystem p in GetComponentsInChildren<ParticleSystem>())
        {
            p.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
