using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverBehaviour : MonoBehaviour
{
    public List<GameObject> objectsToDeactivate;
    public List<GameObject> objectsToActivate;
    public GameObject player;

    public AudioClip AudioClip => _audioClip;
    [SerializeField] private AudioClip _audioClip;

    public AudioSource AudioSource => _audioSource;
    private AudioSource _audioSource;

    [SerializeField] private bool _fired = false;
    
    private void SwitchHandle() {
        Transform leverTrans = this.gameObject.transform.Find("Lever Handle");
        if (leverTrans != null) {
            Vector3 currentRotation = leverTrans.localRotation.eulerAngles;
            currentRotation.x = -currentRotation.x;
            leverTrans.transform.localRotation = Quaternion.Euler(currentRotation);
        }
        AudioSource.PlayOneShot(AudioClip);
    }

    private void DeactivateLever() {
        this.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.clip = AudioClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_fired) {   
            if (Input.GetKeyDown(KeyCode.E) && DistanceService.IsObjectWithinPlayerReach(player.transform.position, transform.position)){
                _fired = true;
                SwitchHandle();
                foreach (GameObject maze in objectsToDeactivate) maze.SetActive(false);
                foreach (GameObject maze in objectsToActivate) maze.SetActive(true);
                Invoke("DeactivateLever", 2);
            }
        }
    }
}
