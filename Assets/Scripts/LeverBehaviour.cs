using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverBehaviour : MonoBehaviour
{
    public List<GameObject> objectsToDeactivate;
    public List<GameObject> objectsToActivate;
    public GameObject player;
    [SerializeField] private float _reachDistance = 2.0f;
    [SerializeField] private bool _fired = false;
    
    private void SwitchHandle() {
        Transform leverTrans = this.gameObject.transform.Find("Lever Handle");
        if (leverTrans != null) {
            Vector3 currentRotation = leverTrans.localRotation.eulerAngles;
            currentRotation.x = -currentRotation.x;
            leverTrans.transform.localRotation = Quaternion.Euler(currentRotation);
        }
        // TODO Play Sound
    }

    private void DeactivateLever() {
        this.gameObject.SetActive(false);
    }

    private bool IsObjectWithinPlayerReach() {
        return Vector3.Distance(player.transform.position, transform.position) < _reachDistance;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!_fired) {   
            if (Input.GetKeyDown(KeyCode.E) && IsObjectWithinPlayerReach()){
                _fired = true;
                SwitchHandle();
                foreach (GameObject maze in objectsToDeactivate) maze.SetActive(false);
                foreach (GameObject maze in objectsToActivate) maze.SetActive(true);
                Invoke("DeactivateLever", 2);
            }
        }
    }
}
