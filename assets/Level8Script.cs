using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level8Script : MonoBehaviour
{

    float cntdnw = 60.0f;
    public Text disvar;

    // Update is called once per frame
    void Update()
    {
        if (cntdnw > 0)
        {
            cntdnw -= Time.deltaTime;
        }

        double b = System.Math.Round(cntdnw, 2);


        disvar.text = b.ToString();

        if (cntdnw < 0)

        {
            SceneManager.LoadScene("level0");
            Debug.Log("Completed");

        }
    }
}
