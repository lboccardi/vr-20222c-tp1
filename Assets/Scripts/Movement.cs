using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward_vector = transform.Find("Camera Offset").transform.Find("Main Camera").transform.forward;
        forward_vector.y = 0;

        if (Input.GetKey("up"))
            gameObject.GetComponent<Rigidbody>().velocity = forward_vector * (2f);
        else if (Input.GetKey("down"))
            gameObject.GetComponent<Rigidbody>().velocity = forward_vector * (-2f);
        else
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        
        if (Input.GetKey("left"))
            gameObject.GetComponent<Rigidbody>().angularVelocity = new Vector3(0,-1.2f,0);
        else if (Input.GetKey("right"))
            gameObject.GetComponent<Rigidbody>().angularVelocity = new Vector3(0,1.2f,0);
        else
            gameObject.GetComponent<Rigidbody>().angularVelocity = new Vector3(0,0,0);
    }
}
