using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePlatforms : MonoBehaviour
{
    public GameObject player;
    public GameObject[] platforms;
    public GameObject lever;
    public bool leverOn;

    //allows for wiggle room in positions
    public float give;
    // Start is called before the first frame update
    void Start()
    {
        leverOn = false;
        for(int i = 0; i < platforms.Length; i++)
        {
            platforms[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!leverOn && Input.GetButtonDown("Enter"))
            activateLever();

        return;
    }

    private void activateLever()
    {
        //first check if in range
        float compare = Mathf.Abs(player.transform.position.x - lever.transform.position.x);

        if(compare < give && compare > 0)
        {
            //lever.transform.rotation.y = 180;
            for(int i = 0; i < platforms.Length; i++)
            {
                platforms[i].SetActive(true);
            }
        }

        return; 
    }
}
