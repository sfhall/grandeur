using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerData : MonoBehaviour
{
    public GameObject player;
    public int level;
    public float health;
    public float[] position;
    public int numKeys;
    // Start is called before the first frame update
    void Start()
    {
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;

        level = getLevel();
    }

    void Update()
    {
        numKeys = keys();
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }

    int getLevel()
    {
        string levelName = SceneManager.GetActiveScene().name;
        int theLevel = 0;

        //not the best way to do this but oh well
        switch (levelName)
        {
            case "Level0":
                theLevel = 0;
                break;
            case "Level1":
                theLevel = 1;
                break;
            case "Level2":
                theLevel = 2;
                break;
            case "Level3":
                theLevel = 3;
                break;
            case "Level4":
                theLevel = 4;
                break;
            case "Level5":
                theLevel = 5;
                break;
            case "Level6":
                theLevel = 6;
                break;
            case "Level7":
                theLevel = 7;
                break;
            case "Level8":
                theLevel = 8;
                break;
        }
        return theLevel;
    }

    int keys()
    {
        PlayerKeys pkeys = GetComponent<PlayerKeys>();
        numKeys = pkeys.numKeys;
        return numKeys;
    }
}
