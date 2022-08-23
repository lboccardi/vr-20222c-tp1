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
        // if (Input.GetKey("up"))
        //     gameObject.transform.Translate(0,0,5f * Time.deltaTime);
        // if (Input.GetKey("down"))
        //     gameObject.transform.Translate(0,0,-5f * Time.deltaTime);
        // if (Input.GetKey("left"))
        //     gameObject.transform.Rotate(0,-100f * Time.deltaTime,0);
        // if (Input.GetKey("right"))
        //     gameObject.transform.Rotate(0,100f * Time.deltaTime,0);
        if (Input.GetKey("up"))
            gameObject.GetComponent<Rigidbody>().velocity = gameObject.transform.forward * (100f * Time.deltaTime);
        else if (Input.GetKey("down"))
            gameObject.GetComponent<Rigidbody>().velocity = gameObject.transform.forward * (-100f * Time.deltaTime);
        else
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        
        if (Input.GetKey("left"))
            gameObject.GetComponent<Rigidbody>().angularVelocity = new Vector3(0,-100f * Time.deltaTime,0);
        else if (Input.GetKey("right"))
            gameObject.GetComponent<Rigidbody>().angularVelocity = new Vector3(0,100f * Time.deltaTime,0);
        else
            gameObject.GetComponent<Rigidbody>().angularVelocity = new Vector3(0,0,0);
    }
}
