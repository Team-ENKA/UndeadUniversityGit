using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCuredZombiea : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject, 2);
            Debug.Log("Zombie removed");
        }
    }

}
