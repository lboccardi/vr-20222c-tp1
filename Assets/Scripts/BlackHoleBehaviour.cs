using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleBehaviour : MonoBehaviour
{
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private float speed = 2.0f;
    
    public GameObject player;
    public GameObject ladder;
    public GameObject final_cube;
    [SerializeField] private float _reachDistance = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.position;    
    }

    private bool IsObjectWithinPlayerReach()
    {
        //Ver de acceder a las dos primeras coordenadas X y Z de la escalera para hacer la distancia con eso y que no me tome la altura
        float player_x = player.transform.position.x;
        float player_z = player.transform.position.z;
        float ladder_x = ladder.transform.position.x;
        float ladder_z = ladder.transform.position.z;

        Vector2 player_2d = new Vector2(player_x, player_z);
        Vector2 ladder_2d = new Vector2(ladder_x, ladder_z);

        return Vector2.Distance(player_2d, ladder_2d) < _reachDistance;
        //return Vector3.Distance(player.transform.position, ladder.transform.position) < _reachDistance;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _startPosition + new Vector3(0.0f, 0.4f * Mathf.Sin(speed * Time.time), 0.0f);

        if (IsObjectWithinPlayerReach()) 
        {
            player.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        }

        if (player.transform.position.y > 4.5)
        {
            ladder.SetActive(false);
            this.gameObject.SetActive(false);
            final_cube.SetActive(true);
            
            player.transform.position = new Vector3(0.0f, 0.1f, 0.0f);
        }
    }
}
