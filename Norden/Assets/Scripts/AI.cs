using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    [SerializeField] public float HP;
    [SerializeField] public float Damage;
    [SerializeField] public float speed;

    public GameObject destination;
    public GameObject player;
    public GameObject headQuarters;

    private void Start()
    {
        if (destination == null)
        {
            destination = GameObject.FindGameObjectWithTag("HeadQuarters");
        }

        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        if (headQuarters == null)
        {
            headQuarters = GameObject.FindGameObjectWithTag("HeadQuarters");
        }

        //NavMeshAgent agent = GetComponent<NavMeshAgent>();
        //agent.destination = destination.transform.position;
    }

    private void Update()
    {
        if (HP <= 0)
        {
            Die();
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.GetComponent<Units>().HP -= Damage;

        }
        else if (collision.gameObject.tag == "HeadQuarters")
        {
            headQuarters.GetComponent<HeadQuarters>().HP -= Damage;
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}