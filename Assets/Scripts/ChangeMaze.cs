using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaze : MonoBehaviour
{
    public GameObject maze_to_deactivate;
    public GameObject maze_to_activate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            maze_to_deactivate.SetActive(false);
            maze_to_activate.SetActive(true);
        }
        
    }
}
