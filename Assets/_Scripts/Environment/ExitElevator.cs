using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitElevator : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            SceneManager.LoadScene("Elevator", LoadSceneMode.Single);
    }           //When game object tagged as "Player" hits the item, it loads the 1st scene
}
