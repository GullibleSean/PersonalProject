using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crates : Resources
{
    [SerializeField] public float CrateDollars;

    public override void Triggered()
    {
        GameManager.Instance.AddDollars(CrateDollars);
        gameObject.SetActive(false);
    }
}
