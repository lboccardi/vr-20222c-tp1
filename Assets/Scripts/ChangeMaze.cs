using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaze : MonoBehaviour
{
    public List<GameObject> maze_to_deactivate;
    public List<GameObject> maze_to_activate;
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
        if (Vector3.Distance(player.transform.position, transform.position) < 2 && Input.GetKeyDown(KeyCode.E)){
            foreach (GameObject maze in maze_to_deactivate){
                maze.SetActive(false);
            }
            foreach (GameObject maze in maze_to_activate){
                maze.SetActive(true);
            }
        }
        
    }
}
