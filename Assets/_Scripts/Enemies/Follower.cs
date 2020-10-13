using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UIElements;

public class Follower : MonoBehaviour
{

    public Transform targetTransform;
    public float enemySpeed;
    public Transform enemyTransform;
    public Transform spriteRotation;
    public float stutter;
    public float stutterSpeed;

    // Update is called once per frame
    void Update()
    {

        if (stutter >= 0)
        {

            stutter = stutter - Time.deltaTime;
            stutterSpeed = 0.1f;
            
        }
        else
            stutterSpeed = 0.6f;

        Vector2 targetPos = targetTransform.position;
        Vector2 OP = enemyTransform.position;
        targetPos.x = targetPos.x - OP.x;
        targetPos.y = targetPos.y - OP.y;
        float enemyRotation = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;

        spriteRotation.rotation = Quaternion.Euler(new Vector3(0, 0, enemyRotation + 90f));

        //Creates a new Vector2 which is used to move the zombie. this Vector2 is multiplied by Time.deltaTime to get the same speed no matter what FrameRate is being played at, and uses ESpeed to determine what speed the zombie moves at
        Vector2 moveTo = new Vector2(targetTransform.position.x, targetTransform.position.y);
        Vector2 moveFrom = new Vector2(enemyTransform.position.x, enemyTransform.position.y);

        transform.position = Vector2.MoveTowards(moveFrom, moveTo, enemySpeed * stutterSpeed);

    }

    public void Stutter()
    {
        stutter = 0.8f;
    }
    

}
