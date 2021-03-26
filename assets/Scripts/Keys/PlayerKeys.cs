using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeys : MonoBehaviour
{
    [Range(0,8)] public int numKeys;
    public GameObject UIKeyHolder;

    GameObject[] childKeys = new GameObject[8];


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 8; i++){
            childKeys[i] = UIKeyHolder.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < numKeys; i++){
            childKeys[i].SetActive(true);
        }
    }

    public void AddKey(){
        if (numKeys < 8)
            numKeys++;
        for(int i = 0; i < numKeys; i++)
            childKeys[i].SetActive(true);
    }
}
