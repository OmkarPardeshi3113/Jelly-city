using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Animator fireANI;
    public AudioSource shootSFX;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
            fireANI.SetBool("isFire", true);
        }

        if(Input.GetButtonUp("Fire1"))
        {
            fireANI.SetBool("isFire", false);
        }
    }

    public void Shoot()
    {
        shootSFX.Play();
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
