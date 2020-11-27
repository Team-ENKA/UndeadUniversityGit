using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropKey : MonoBehaviour
{
    public ZombieInfectionController health;
    public GameObject keyPrefab;
    private int counter = 1;


    private void Update()
    {
        if (health.currentHealth <= 0 && counter == 1)
        {
            counter--;
            Debug.Log("Key dropped");
            Instantiate(keyPrefab, transform.position, Quaternion.identity);
        }
    }
}

