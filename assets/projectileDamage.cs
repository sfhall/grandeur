using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileDamage : MonoBehaviour
{
    public PlayerHealth player;

    public int damage = 20;


    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.CompareTag("Player"))
        {
            player.TakeDamage(damage);
        }

        Destroy(this.gameObject);

        //hitInfo.GetComponent<PlayerHealth>().TakeDamage(damage);
        //Debug.Log("hazard");
    }
}
