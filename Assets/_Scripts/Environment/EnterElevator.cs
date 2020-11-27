using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterElevator : MonoBehaviour
{   
    public Transform playerTransform;
    public GameObject LunchLass;

    private void Start()
    {

        LunchLass = GameObject.FindGameObjectWithTag("Player");
        playerTransform = LunchLass.GetComponent<Transform>();

    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {

        if (collision.gameObject.tag == "Player")
        {

            playerTransform.position = Vector2.zero;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);

        }   

    }

}
