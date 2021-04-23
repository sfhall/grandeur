using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPuzzel : MonoBehaviour
{
    public GameObject key;
    public GameObject closedChest;
    public GameObject openChest;
    // Start is called before the first frame update
    void Start()
    {
        key.SetActive(false);
        closedChest.SetActive(true);
        openChest.SetActive(false);
    }

    public void Check()
    {
        key.SetActive(true);
        closedChest.SetActive(false);
        openChest.SetActive(true);
    }
}
