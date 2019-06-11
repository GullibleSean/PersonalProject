using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemySpawnData
{
    public GameObject enemyPrefab;
    public Transform spawnLocation;
}

public class EnemyManager : MonoBehaviour
{
    public List<EnemySpawnData> spawnData;
    public float spawnInterval;

    public bool SpawningEnabled { get { return spawningEnabled; } set { spawningEnabled = value; } }
    private bool spawningEnabled = false;

    public void StartSpawning()
    {
        spawningEnabled = true;
        StartCoroutine("SpawnEnemyRoutine");
    }

    public void StopSpawning()
    {
        StopCoroutine("SpawnEnemyRoutine");
    }

    private IEnumerator SpawnEnemyRoutine()
    {
        while (spawningEnabled)
        {
            yield return new WaitForSeconds(spawnInterval);

            foreach (var spawner in spawnData)
            {
                Instantiate(spawner.enemyPrefab, spawner.spawnLocation.position, Quaternion.identity);
            }
        }
    }
}