using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction{
    horizontal,
    vertical
}

public class MovingPlatform : MonoBehaviour
{
    public float speed = 2f;
    Vector3 startPosition;

    // Line movement vars
    public Direction dir; 
    public float lineDistance = 5f; 

    // Start is called before the first frame update
    void Start()
    {
        // Set start position
        startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    // Move the platform in a straight line in movementOrientation
    public void move() 
    {
        // Get current coordenates 
        float x = startPosition.x;
        float y = startPosition.y;
        float z = startPosition.z;

        // Calculating next position according to the orientation selected
        switch (dir) {
            case Direction.horizontal:
                x = startPosition.x + Mathf.Sin(Time.time * speed) * lineDistance;
            break;
            case Direction.vertical:
                y = startPosition.y + Mathf.Sin(Time.time * speed) * lineDistance;
            break;
        }

        // Moving platform
        this.transform.position = new Vector3(x,y,z);
    }

}
