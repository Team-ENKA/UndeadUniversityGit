using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class OnHitMelee : MonoBehaviour
{

    public ZombieDamageController die;
    
    private void OnTriggerStay2D(Collider2D collision)
    {

        die = collision.GetComponent<ZombieDamageController>();
        die.GotShot();
    }

}
