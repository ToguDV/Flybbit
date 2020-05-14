using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Showvalue : MonoBehaviour
{
    public bool score;
    public bool carrots;
    public Text text;
    public Text record;
    public bool recordd;
    void Start()
    {
        money.carrots = PlayerPrefs.GetInt("carrots", 0);
        Platform.score = 0;
        if (recordd)
        {
            record.text = "PM:" + PlayerPrefs.GetInt("record", 0).ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (carrots)
        {
            text.text = money.carrots.ToString();
          
        }
        if (score)
        {
            text.text = "P:" + Platform.score.ToString();
           
        }

    }
}
