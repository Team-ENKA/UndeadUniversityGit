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
    public int movementType;

    //the speed value is changed depending on movement direction as to not double movement speed when going diagonally
    private float Speed = 18f;
    private float speedModifier = 1.4f;
    public float stamina;
    public float staminaRegenCooldown;
    public TextMesh staminaText;

    // Update is called once per frame
    void Update()
    {

        if (staminaRegenCooldown <= 0f && stamina < 16f)
            stamina = stamina + Time.deltaTime;
        staminaRegenCooldown = staminaRegenCooldown - Time.deltaTime;

        staminaText.text = ("Stamina" + stamina);

        //if both inputs for the UpDown variable is not pressed, it will be set to 0
        //if either are pressed, they will set the UpDown variable to the number below



        if (!Input.GetKey("w") && !Input.GetKey("s"))
        {

            UpDown = 0f;

        }

        if (Input.GetKey("w"))
        {

            UpDown = 1f;
            if (Input.GetKey("left shift"))
            {

                if (stamina >= 0.1f)
                {

                    stamina = stamina - Time.deltaTime;
                    speedModifier = 2.8f;
                    staminaRegenCooldown = 2.5f;

                }
                else
                    speedModifier = 1.4f;

            }
            else
                speedModifier = 1.4f;

        }

        if (Input.GetKey("s"))
        {

            UpDown = -1f;
            if (Input.GetKey("left shift"))
            {

                if (stamina >= 0.1f)
                {

                    stamina = stamina - Time.deltaTime;
                    speedModifier = 2.8f;
                    staminaRegenCooldown = 2.5f;

                }
                else
                    speedModifier = 1.4f;

            }
            else
                speedModifier = 1.4f;

        }



        //if both inputs for the Sideways variable is not pressed, it will be set to 0
        //if either are pressed, they will set the Sideways variable to the number below
        if (!Input.GetKey("a") && !Input.GetKey("d"))
        {

            Sideways = 0f;

        }

        if (Input.GetKey("d"))
        {

            Sideways = 1f;
            if (Input.GetKey("left shift"))
            {

                if (stamina >= 0.1f)
                {

                    stamina = stamina - Time.deltaTime;
                    speedModifier = 2.8f;
                    staminaRegenCooldown = 2.5f;

                }
                else
                    speedModifier = 1.4f;

            }
            else
                speedModifier = 1.4f;

        }

        if (Input.GetKey("a"))
        {

            Sideways = -1f;
            if (Input.GetKey("left shift"))
            {

                if (stamina >= 0.1f)
                {

                    stamina = stamina - Time.deltaTime;
                    speedModifier = 2.8f;
                    staminaRegenCooldown = 2.5f;

                }
                else
                    speedModifier = 1.4f;

            }
            else
                speedModifier = 1.4f;

        }

        //uses a regular x,y coordinate system to determine which direction to rotate
        if (UpDown == 0 && Sideways == 0)
            Speed = 12f;

        //if the Sideways variable is 0 it will check the UpDown variable to determine if the player should rotate
        if (Sideways == 0)
        {

            if (UpDown == 1)
            {

                Speed = 18f;

            }

            if (UpDown == -1)
            {

                Speed = 18f;

            }

        }

        //if the UpDown variable is 0 it will check the Sideways variable to determine if the player should rotate
        if (UpDown == 0)
        {

            if (Sideways == 1)
            {

                Speed = 18f;

            }

            if (Sideways == -1)
            {

                Speed = 18f;

            }

        }

        Vector2 mousePos = Input.mousePosition;
        Vector2 OP = Camera.main.WorldToScreenPoint(playerTransform.position);
        mousePos.x = mousePos.x - OP.x;
        mousePos.y = mousePos.y - OP.y;
        float playerRotation = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

        if (movementType == 0)
            spriteRotation.rotation = Quaternion.Euler(new Vector3(0, 0, playerRotation + 90f));

        if (movementType == 1)
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, playerRotation + 90f));

        //creates a new vector2 using the 2 variables below
        Vector2 move = new Vector2(Sideways, UpDown);

        //uses the Vector3 just created to move the character using the speed variable and deltaTime as to smooth out the movement independent of framerate
        transform.Translate(move * Time.deltaTime * Speed * speedModifier);

    }

    public void MovementChange ()
    {

        Debug.Log("poff");

        if (movementType > 0)
        {

            movementType = 0;

        } else
            movementType = 1;

        

    }

}
