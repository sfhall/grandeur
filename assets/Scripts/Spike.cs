using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public Transform respawnpoint;
    void OnTriggerEnter2D(Collider2D obj)
    {
        Transform playposition = obj.GetComponent<Transform>();
        playposition.position = respawnpoint.position;
    }
}
