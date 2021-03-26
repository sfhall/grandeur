using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    // used to attempt to avoid double collision that sometimes happens due to player x2 colliders
    int gather = 0;

    void OnTriggerEnter2D(Collider2D other){
        PlayerKeys pkeys = other.GetComponent<PlayerKeys>();
        if (pkeys != null){
            if (gather == 0 ){
                pkeys.AddKey();
                Destroy(gameObject);
                gather++;
            }
        }
    }
}
