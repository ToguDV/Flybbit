using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class troll : MonoBehaviour
{
    public bool activado;
    public float speed;
    public GameObject padre;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (activado)
        {
            padre.transform.Translate(new Vector3(1*speed*Time.deltaTime,0,0));
            
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "rabbit")
        {
            activado = true;
        }
    }
}
