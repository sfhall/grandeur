using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeploySwords : MonoBehaviour
{
    public GameObject swordPrefab;
    public float respawnTime = 4.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(spawnSwords());
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(swordPrefab) as GameObject;
        //a.transform.position = new Vector2(screenBounds.x * -2, screenBounds.y);
    }

    IEnumerator spawnSwords()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
