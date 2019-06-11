using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerDetect : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject destination;
    public GameObject player;

    private void Start()
    {
        NotInSight();
    }

    private void Update()
    {
        if (destination == null)
        {
            destination = GameObject.FindGameObjectWithTag("HeadQuarters");
        }

        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerInSight();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            NotInSight();
        }
    }

    public void PlayerInSight()
    {
        agent.destination = player.transform.position;
    }

    public void NotInSight()
    {
        agent.destination = destination.transform.position;
    }
}
