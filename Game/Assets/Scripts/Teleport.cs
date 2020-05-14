using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Camera camera;
    
    // Start is called before the first frame update

    public void Start()
    {
        
    }

    public void Update()
    {
       if(transform.position.x >= 3f)
        {
            transform.position = new Vector3(-transform.position.x, transform.position.y);
        }
    }

}
