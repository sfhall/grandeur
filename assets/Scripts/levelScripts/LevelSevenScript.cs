using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSevenScript : MonoBehaviour
{
    public GameObject[] gems;
    public GameObject UIGems;
    
    private int gather;

    // Start is called before the first frame update
    void Start()
    {
        gather = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void pickupGems()
    {

    }

    void OnTriggerEnter2D(Collider2D other){
        if (gems != null){
            if (gather == 0 ){
                Destroy(gameObject);
                gather++;
            }
        }
    }
}
