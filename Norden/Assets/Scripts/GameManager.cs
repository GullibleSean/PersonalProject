using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] float totalDollars;

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

    
}
