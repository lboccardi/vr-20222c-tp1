using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenExit : MonoBehaviour
{
    [SerializeField] private GameObject _exit;
    // Start is called before the first frame update
    void Start()
    {
        _exit = this.transform.parent.Find("Exit").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            if (_exit != null) {
                _exit.SetActive(true);
            }
        }
    }
}
