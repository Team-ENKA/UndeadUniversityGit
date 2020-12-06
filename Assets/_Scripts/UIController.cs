using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public int pauseMenu;
    public GameObject inGameMenu;
    public GameObject inGameUI;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
            if (pauseMenu == 1)
            {

                inGameMenu.SetActive(false);
                inGameUI.SetActive(true);
                pauseMenu = 0;

            }
            else
            {

                inGameMenu.SetActive(true);
                inGameUI.SetActive(false);
                pauseMenu = 1;

            }

        if (pauseMenu == 1)
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W))
            {

                inGameMenu.SetActive(false);
                inGameUI.SetActive(true);
                pauseMenu = 0;

            }

    }
}
