using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    [SerializeField] public float dmg;
    [SerializeField] public GameObject AI;
    [SerializeField] public GameObject bullet;

    private void Start()
    {
        if (AI == null)
        {
            AI = GameObject.FindGameObjectWithTag("Enemy");
        }
        if (bullet == null)
        {
            bullet = GameObject.FindGameObjectWithTag("Bullets");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AI.GetComponent<AI>().HP -= dmg;
        }
        bullet.SetActive(false);
    }
}
