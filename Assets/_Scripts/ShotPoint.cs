using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotPoint : MonoBehaviour
{

    public Transform ShootingDirection;

    // Update is called once per frame
    void Update()
    {

        //Sets the position for one of the transforms used to cast a line by the Shooting script
        transform.position = new Vector3(ShootingDirection.position.x, ShootingDirection.position.y, 0f);

    }
}
