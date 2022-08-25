using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letrero : MonoBehaviour
{
    public GameObject palanca;

    private TextMesh letrero;
    private MeshRenderer meshRenderer;

    public bool yawOnly = false;
    private float minimalViewDistance = 0.6f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        letrero = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (palanca.activeSelf)  // Texto aparece cuando esta la palanca correspondiente
        {
            var cam = Camera.main;
            if (cam == null) return;

            var lookDir = transform.position - cam.transform.position;
            if (yawOnly) lookDir.y = 0;

            if(Vector3.SqrMagnitude(lookDir) < minimalViewDistance)
            {
                meshRenderer.enabled = true;
                transform.rotation = Quaternion.LookRotation(lookDir);
            }
            else
            {
                meshRenderer.enabled = false;
            }
        }
        else
        {
            meshRenderer.enabled = false;
        }
    }
}
