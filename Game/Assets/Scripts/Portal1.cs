using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal1 : MonoBehaviour
{
    public GameObject portal2;
    public GameObject conejo;

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "rabbit")
        {
            conejo = GameObject.FindGameObjectWithTag("rabbit");
            conejo.transform.position = portal2.transform.position;
           

        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "rabbit")
        {
            Player.saltarExterno = true;
        }


    }
}