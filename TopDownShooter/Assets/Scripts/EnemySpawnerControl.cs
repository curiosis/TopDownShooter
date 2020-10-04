using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerControl : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemies;
    int randomValSpawnPoint, randomValEnemies;
    public static bool spawnAllowed;

    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnEnemies", 0f, 1f);
    }

    void SpawnEnemies()
    {
        if (spawnAllowed)
        {
            randomValSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomValEnemies = Random.Range(0, enemies.Length);
            Instantiate(enemies[randomValEnemies], spawnPoints[randomValSpawnPoint].position, Quaternion.identity);
        }
    }
}
