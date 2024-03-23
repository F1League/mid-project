using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text t;
    public float n;

    void Update()
    {
        n -= Time.deltaTime;
        t.text = Mathf.Round(n).ToString();

        if (n <=0)
        {
            t.text = "TIME UP!";
        }
    }
}