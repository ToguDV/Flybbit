using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrot : MonoBehaviour
{
    public float positionx;
    public GameObject platformRandom;
    public float separacion = 3f;

    bool touch;

    void Start()
    {
        
        Position();




    }

    // Update is called once per frame
    void Update()
    {

    }
    void Position()
    {
        positionx = Random.Range(-2f, 2f);
        Platform.positiony = Random.Range(Platform.positiony, Platform.positiony + 1.5f);
        transform.position = (new Vector3(positionx, Platform.positiony, 0));
        Platform.positiony = Platform.positiony + separacion;
    }



    void OnBecameInvisible()
    {

    }

    // ...and enable it again when it becomes visible.
    void OnBecameVisible()
    {
        platformRandom = GameObject.Find("camera");
        if (!touch)
        {
            platformRandom.SendMessage("InstantiatePlatform");
            touch = true;
            print("instanacia");
        }



    }

    
}
