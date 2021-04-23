using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInstructions : MonoBehaviour
{
    public float give;
    public bool intsructionsOn;
    public GameObject player;
    public GameObject instructions;
    // Start is called before the first frame update
    void Start()
    {
        intsructionsOn = false;
        foreach(Transform child in transform)
            child.gameObject.SetActive(false);
    }

    void Update()
    {
        float compare = Mathf.Abs(player.transform.position.x - instructions.transform.position.x);
        float comparePuzzel = Mathf.Abs(player.transform.position.x - instructions.transform.position.x);
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(compare < give && compare > 0 && !intsructionsOn)
            {
                foreach(Transform child in transform)
                    child.gameObject.SetActive(false);
                
                intsructionsOn = true;
            }
            else if(compare < give && compare > 0 && intsructionsOn)
            {
                foreach(Transform child in transform)
                    child.gameObject.SetActive(true);

                intsructionsOn = false;
            }
        }
    }   
}
