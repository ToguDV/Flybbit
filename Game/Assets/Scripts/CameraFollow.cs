using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float Space;
    public float difference;
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((transform.position.y - target.position.y) < difference)
        {//move if distance from target is greater than 1
            transform.position = (new Vector3(0, target.transform.position.y, -10));
        }

    }
}
