using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSpawner : MonoBehaviour
{
    public EnemyManager spawner;

    private void Awake()
    {
        if (spawner == null)
        {
            Debug.LogError("Spawn Trigger doesn't have a spawner");
        }
        else
        {

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Trigger Enter");
            spawner.StartSpawning();
        }
    }
}
