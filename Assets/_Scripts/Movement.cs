using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{

 
    public GameObject Lunch_lass;
    public Transform spriteRotation;
    public Transform playerTransform;

    public float UpDown = 0f;
    public float Sideways = 0f;

    //the speed value is changed depending on movement direction as to not double movement speed when going diagonally
    public float Speed = 18f;
    private float coffeeBoostTimer = 1f;
    private float coffeeSpeedModifier = 2f;

    // Update is called once per frame
    void Update()
    {

        //if both inputs for the UpDown variable is not pressed, it will be set to 0
        //if either are pressed, they will set the UpDown variable to the number below

        if (Input.GetKey(KeyCode.A))
            Sideways = -1f;
        else
        if (Input.GetKey(KeyCode.D))
            Sideways = 1f;
        else
        {

            Sideways = 0;

        }

        if (Input.GetKey(KeyCode.W))
            UpDown = 1f;
        else
        if (Input.GetKey(KeyCode.S))
            UpDown = -1f;
        else
        {

            UpDown = 0;

        }

        coffeeBoostTimer = coffeeBoostTimer - Time.deltaTime;
        if (coffeeBoostTimer < 1)
        {
            coffeeSpeedModifier = 2;
        }

        Vector2 mousePos = Input.mousePosition;
        Vector2 OP = Camera.main.WorldToScreenPoint(playerTransform.position);
        mousePos.x = mousePos.x - OP.x;
        mousePos.y = mousePos.y - OP.y;
        float playerRotation = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

        spriteRotation.rotation = Quaternion.Euler(new Vector3(0, 0, playerRotation + 90f));

        Vector2 move = new Vector2(Sideways, UpDown);

        transform.Translate(move * Time.deltaTime * Speed * coffeeSpeedModifier);

    }

    public void CoffeeBoost()
    {

        coffeeSpeedModifier = 4;
        coffeeBoostTimer = 6;

    }

}
