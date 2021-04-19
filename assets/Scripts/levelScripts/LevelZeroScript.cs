using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelZeroScript : MonoBehaviour
{
    public GameObject[] doors;
    public GameObject player;
    //this value is use to allow wiggle room for entering doors
    public float give;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Enter"))
        {
            LoadLevel();
        }
    }

    private void LoadLevel()
    {
        //check if in range of door and load approprate scene
        string[] doorNames = {"Level1", "Level2", "Level3", "Level4", "Level5", "Level6", "Level7", "Level8"};
        for(int i = 0; i < 8; i++)
        {
            //Debug.Log(doors[i].transform.localPosition);
            float compare = Mathf.Abs(player.transform.position.x - doors[i].transform.position.x);
            if(compare < give && compare > 0)
                SceneManager.LoadScene(doorNames[i]);
        }
        return;
    }
}
