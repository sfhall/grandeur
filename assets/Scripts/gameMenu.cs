using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMenu : MonoBehaviour
{
    public GameObject parent;
    public bool menuOn;
    // Start is called before the first frame update
    void Start()
    {
        menuOn = false;
        //start with it true to turn menu off
        toggleMenu(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            menuOn = toggleMenu(menuOn);
        }
    }

    bool toggleMenu(bool menuOn)
    {
        if(!menuOn)
        {
            foreach(Transform child in transform)
                child.gameObject.SetActive(true);

            return true;;
        }
        else
        {
            foreach(Transform child in transform)
                child.gameObject.SetActive(false);

            return false;
        }
    }

    public void Save()
    {
        return;
    }

    public void Load()
    {
        return;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
