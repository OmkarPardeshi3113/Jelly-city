using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MechEnemy : MonoBehaviour
{

    public int health = 100; //Enemy Health

    // Patroling Variables
    public float speed;
    public float distance;
    public Transform groundCheck;
    private bool isPatrol = true;
    public Rigidbody2D enemyRB;

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



    void Update()
    {
        // Patroling Logic
        if (isPatrol == true)
        {
            transform.Translate(Vector2.right * speed * Time.fixedDeltaTime);

            RaycastHit2D groundInfo = Physics2D.Raycast(groundCheck.position, Vector2.down, distance);


            if (groundInfo == false)
            {
                Flip();
            }
        }

        // Enemy AI detection logic
        distTOplayer = Vector2.Distance(transform.position, player.position);

        if (distTOplayer <= range)
        {
            

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


    }

    public void Flip()
    {
        transform.Rotate(0f, 180f, 0f);
        //transform.rotation = new Quaternion(0f, 180f, 0f, 0f);
    }
    public void FlipRight()
    {
        //transform.Rotate(0f, 180f, 0f);
        transform.rotation = new Quaternion(0f, 180f, 0f, 0f);
    }

    public void FlipLeft()
    {
        //transform.Rotate(0f, 180f, 0f);
        transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
    }


}
