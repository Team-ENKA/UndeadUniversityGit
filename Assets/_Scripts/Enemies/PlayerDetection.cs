using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{

    public Vector2 scanOrigin;
    public Transform zombieScanTransform;
    public Transform playerPos;
    public AIDestinationSetter Destination;
    int layerMask = 13;

    // Update is called once per frame
    void Update()
    {

        scanOrigin = new Vector2(zombieScanTransform.position.x, zombieScanTransform.position.y);
        RaycastHit2D hit = Physics2D.Linecast(scanOrigin, playerPos.position, layerMask);
        Debug.DrawLine(scanOrigin, playerPos.position, Color.green, 2f);

        if (hit.collider.gameObject.tag == "Player")
            Debug.Log("rawr");

    }
}
