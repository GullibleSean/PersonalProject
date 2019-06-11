using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    [SerializeField] public float HP;
    [SerializeField] public float Damage;
    [SerializeField] public float speed;

    public GameObject destination;
    public GameObject player;
    int current = 0;

    private void Start()
    {
        if (destination == null)
        {
            destination = GameObject.FindWithTag("HeadQuarters");
        }

        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
    }

    private void Update()
    {
        if (HP <= 0)
        {
            Die();
        }

        transform.position = Vector3.MoveTowards(transform.position, destination.transform.position, Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player = other.gameObject.GetComponent<GameObject>();
            //player.TakeDamage(damage);
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}