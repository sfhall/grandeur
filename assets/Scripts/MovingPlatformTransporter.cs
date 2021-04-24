using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformTransporter : MonoBehaviour
{
    private GameObject target=null;
    private Vector3 offset;

    void OnTriggerStay2D(Collider2D obj)
    {
        target = obj.gameObject;
        offset = target.transform.position - transform.position;
    }
    void OnTriggerExit2D(Collider2D obj)
    {
        target = null;
    }
    void LateUpdate()
    {
        if (target != null) 
        {
            target.transform.position = transform.position+offset;
        }
    }
 }
