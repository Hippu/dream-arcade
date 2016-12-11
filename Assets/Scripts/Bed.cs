using UnityEngine;
using System.Collections;

public class Bed : MonoBehaviour
{
    private Controls player;
    public Transform start;

    void Start()
    {
        player = FindObjectOfType<Controls>();
    }

    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //player.transform.position = start.position;
        }
    }
}
