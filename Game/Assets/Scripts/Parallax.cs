using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Transform target;
    public float difference;
    public float speed = 2f;
    public float parallax;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
       
            transform.position = (new Vector3(0, target.transform.position.y * parallax, 1));
        }

    }