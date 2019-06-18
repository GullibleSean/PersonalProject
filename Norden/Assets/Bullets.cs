using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float speed;
    public GameObject bullet;
    public GameObject barrel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            GameObject instaBullet = Instantiate(bullet, barrel.transform.position, barrel.transform.rotation) as GameObject;
            Rigidbody instaBulletRigidbody = instaBullet.GetComponent<Rigidbody>();
            instaBulletRigidbody.AddForce(Vector3.forward * speed);
        }
    }
}
