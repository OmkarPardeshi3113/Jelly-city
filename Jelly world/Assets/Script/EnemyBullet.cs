using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 50;
    public Rigidbody2D bulletRB;
    //public GameObject firePoint;
    //public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
        //transform.position = new Vector2(bulletRB.position.x - 1, bulletRB.position.y);
        bulletRB.velocity = transform.right * speed;
        

        

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth playerdamage = collision.GetComponent<PlayerHealth>();
        if (playerdamage != null)
        {
            playerdamage.TakeDamage(damage);
        }
        //Instantiate(explosion, transform.position, transform.rotation);
        //Destroy(explosion);
        Destroy(gameObject);
    }
}
