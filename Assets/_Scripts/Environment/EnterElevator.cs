using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterElevator : MonoBehaviour
{   
    public Transform playerTransform;
    public GameObject LunchLass;
    public Animator transition;

    public float transitionTime = 1f;

    private void Start()
    {

        LunchLass = GameObject.FindGameObjectWithTag("Player");
        playerTransform = LunchLass.GetComponent<Transform>();

    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {

        if (collision.gameObject.tag == "Player")
        {

            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
            LunchLass.GetComponent<Movement>().enabled = false;

        }   

    }

    IEnumerator LoadLevel(int levelndex)
    {

        transition.SetTrigger("Start");
   
        yield return new WaitForSeconds(transitionTime);

        playerTransform.position = Vector2.zero;
        LunchLass.GetComponent<Movement>().enabled = true;
        SceneManager.LoadScene(levelndex);

    }

}
