using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSevenScript : MonoBehaviour
{
    public GameObject[] gems;
    public GameObject[] gameGems;
    public GameObject UIGems;
    
    private int numGems;

    // Start is called before the first frame update
    void Start()
    {
        numGems = gems.Length;

        for(int i = 0; i < numGems; i++)
            gems[i].SetActive(true);
    }
}
