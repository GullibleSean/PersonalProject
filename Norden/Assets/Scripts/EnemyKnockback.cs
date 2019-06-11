using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKnockback : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public Vector3 moveDirection;
    public GameObject player;

    private void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
            playerRigidbody = player.GetComponent<Rigidbody>();
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerRigidbody.AddForce(moveDirection);
        }
    }
}
