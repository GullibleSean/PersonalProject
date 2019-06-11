using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadQuarters : MonoBehaviour
{
    [SerializeField] public float HP;
    public GameObject units;
    public GameObject spawnPoint;
    void Update()
    {
        if (HP <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }

    public void SpawnUnits()
    {
        Instantiate(units, spawnPoint.transform.position, Quaternion.identity);
    }
}
