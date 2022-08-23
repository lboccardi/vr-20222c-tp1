using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Input2Activate : MonoBehaviour
{
    public GameObject object2disapear;
    bool other_object_is_active = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            print("oh_Yeah");
            other_object_is_active = ! other_object_is_active;
            object2disapear.SetActive(other_object_is_active);
        }
    }
}
