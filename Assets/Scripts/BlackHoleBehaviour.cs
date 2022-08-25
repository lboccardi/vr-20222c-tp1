using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleBehaviour : MonoBehaviour
{
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private float speed = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _startPosition + new Vector3(0.0f, 0.4f * Mathf.Sin(speed * Time.time), 0.0f);
    }
}
