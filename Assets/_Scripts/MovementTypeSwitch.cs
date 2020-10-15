using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementTypeSwitch : MonoBehaviour
{

    public Movement movement;
    
    public void MovementSwitch () 
    {

        movement.MovementChange();
    
    }
    
}
