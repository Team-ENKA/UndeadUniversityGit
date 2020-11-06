using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{

    public Transform zombieScanTransform;
    public Transform playerPos;
    public GameObject player;
    public AIDestinationSetter Destination;
    int layerMask = 1 << 9;

    private void Start()
    {

        layerMask = ~layerMask;
        player = GameObject.FindGameObjectWithTag("Player");
        playerPos = player.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit2D hit = Physics2D.Linecast(zombieScanTransform.position, playerPos.position, layerMask);

        Debug.DrawLine(zombieScanTransform.position, playerPos.position, Color.green, 2f);

        if (hit.collider.gameObject.tag == "Player")
        {

            Destination.enabled = true;

        }

    }
}
