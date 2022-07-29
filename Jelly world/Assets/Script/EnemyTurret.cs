using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurret : MonoBehaviour
{
    public int health = 100; //Enemy Health
    public Rigidbody2D enemyRB; // Enemy RigidBody
    public Animator turretANI; // Enemy Animation

    // Enemy shooting variables
    public Transform firePoint;
    public GameObject bulletPrefab;
    private float fireRate = 1f;
    private float nextFire = 0.0f;

    // Enemy AI detection
    public float range = 5f;
    private float distTOplayer;
    public Transform player;
    //public float delay = 2f;

    // Update is called once per frame
    void Update()
    {
        // Enemy AI detection logic
        distTOplayer = Vector2.Distance(transform.position, player.position);

        if (distTOplayer <= range)
        {
            
            if (player.position.x > transform.position.x && transform.localScale.x < 0)
            {

                //Flip();
            }

            if (player.position.x < transform.position.x && transform.localScale.x > 0)
            {

                //Flip();
            }


            
            enemyRB.velocity = Vector2.zero;

            turretANI.SetBool("isShoot", true);
            Shoot();
        }
    }

    public void TakeDamage(int damage) // To damage Enemy
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die() // To Kill Enemy
    {
        Destroy(gameObject);
    }


    public void Shoot() // Allowing Enemy to shoot
    {

        if (nextFire <= 0)
        {



            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            nextFire = 1f / fireRate;
        }

        nextFire -= Time.deltaTime;

        turretANI.SetBool("isShoot", false);
    }
}
