using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Animator animator;

    public float shootRate = 2f;
    float nextShootTime = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextShootTime)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
                nextShootTime = Time.time + shootRate;
            }
        }
    }

    void Shoot()
    {
        // shooting logic
        animator.SetTrigger("Shoot");
        animator.SetBool("IsJumping", false);
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
