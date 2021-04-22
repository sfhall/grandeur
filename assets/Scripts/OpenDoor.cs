using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    public GameObject key;
    public GameObject grate;
    public GameObject door;
    public GameObject player;

    public bool open;

    public float give;

    void Start()
    {
        open = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(key == null)
        {
            grate.SetActive(false);
            open = true;
        }
        
        if(Input.GetButtonDown("Enter"))
        {
            loadLevel();
        }
    }

    void loadLevel()
    {
        float compare = Mathf.Abs(player.transform.position.x - door.transform.position.x);
        Debug.Log(compare);

        if(compare < give && compare > 0 && open)
            SceneManager.LoadScene("Level0");
    }
}
