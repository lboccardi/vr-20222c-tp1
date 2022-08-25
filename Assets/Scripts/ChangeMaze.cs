using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaze : MonoBehaviour
{
    public List<GameObject> maze_to_deactivate;
    public List<GameObject> maze_to_activate;
    public GameObject player;
    public float distance;
    private bool fired = false;
    // Start is called before the first frame update
    
    private void SwitchHandle() {
        Transform leverTrans = this.gameObject.transform.Find("Lever Handle");
        if (leverTrans != null) {
            Vector3 currentRotation = leverTrans.localRotation.eulerAngles;
            currentRotation.x = -currentRotation.x;
            leverTrans.transform.localRotation = Quaternion.Euler(currentRotation);
        }
    }

    private void DeactivateLever() {
        this.gameObject.SetActive(false);
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!fired) {
            distance = Vector3.Distance(player.transform.position,transform.position);   
            if (Vector3.Distance(player.transform.position, transform.position) < 2 && Input.GetKeyDown(KeyCode.E)){
                SwitchHandle();
                foreach (GameObject maze in maze_to_deactivate){
                    maze.SetActive(false);
                }
                foreach (GameObject maze in maze_to_activate){
                    maze.SetActive(true);
                }
                fired = true;
                Invoke("DeactivateLever", 2);
            }
        }
    }
}
