using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] float totalDollars;
    [SerializeField] public GameObject units;
    [SerializeField] public GameObject spawnPoint;

    void Start()
    {
        if(Instance == null)
        {
            Instance = this;
        }

    }

    public void AddDollars(float toAdd)
    {
        totalDollars += toAdd;
        print(totalDollars);
    }

    public void spawnUnit()
    {
        if (totalDollars == 100f)
        {
            Instantiate(units, spawnPoint.transform.position, Quaternion.identity);
            totalDollars -= 100f;
        }
    }

    
}
