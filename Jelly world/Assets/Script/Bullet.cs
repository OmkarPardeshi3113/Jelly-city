using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 1f;
    public int damage = 50;
    public Rigidbody2D bulletRB;
    //public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        bulletRB.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy=collision.GetComponent<Enemy>();
        if(enemy!= null)
        {
            enemy.TakeDamage(damage);
        }

        EnemyTurret turret = collision.GetComponent<EnemyTurret>();
        if (turret != null)
        {
            turret.TakeDamage(damage);
        }

        MechEnemy mech = collision.GetComponent<MechEnemy>();
        if (mech != null)
        {
            mech.TakeDamage(damage);
        }

        BossTurret bt = collision.GetComponent<BossTurret>();
        if(bt !=null)
        {
            bt.TakeDamage(damage);
        }



        //Instantiate(explosion, transform.position, transform.rotation);
        //Destroy(explosion);
        Destroy(gameObject);
    }
}
