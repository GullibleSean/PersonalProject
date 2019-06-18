using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadQuarters : MonoBehaviour
{
    [SerializeField] public float HP;
    [SerializeField] public GameObject gameManager;

    public void Awake()
    {
        if (gameManager == null)
        {
            gameManager = GameObject.FindGameObjectWithTag("GM");
        }
    }

    private void Update()
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
        gameManager.GetComponent<GameManager>().spawnUnit();
    }
}
