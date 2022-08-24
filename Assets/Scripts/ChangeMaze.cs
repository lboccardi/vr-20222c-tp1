using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaze : MonoBehaviour
{
    public GameObject maze_to_deactivate;
    public GameObject maze_to_activate;
    public GameObject player;
    public float distance; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position,transform.position);   
        if (Vector3.Distance(player.transform.position, transform.position) < 1.3 && Input.GetKeyDown(KeyCode.E)){
            maze_to_deactivate.SetActive(false);
            maze_to_activate.SetActive(true);
        }
        
    }
}
