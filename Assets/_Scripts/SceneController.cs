﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

public class SceneController : MonoBehaviour
{

    public GameObject volumeSlider;
    [SerializeField]
    private float volumeSliderValue;
    public AudioSource mainCamAudio;
    private GameObject player;
    public new List<GameObject> AudioSourcesInScene;

    //Quits the game when the quit game button is pressed
    public void Quit()
    {

        Application.Quit();

    }

    public void Respawn()
    {

        int sceneNum = SceneManager.GetActiveScene().buildIndex;

        if (sceneNum == 1)
        {

            Destroy(GameObject.FindGameObjectWithTag("Canvas"));
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            Destroy(GameObject.FindGameObjectWithTag("MainCamera"));
            Destroy(GameObject.FindGameObjectWithTag("ShootingDir"));
            Destroy(GameObject.FindGameObjectWithTag("EventController"));

        }

        player = GameObject.FindGameObjectWithTag("Player");

        player.GetComponent<Transform>().position = GameObject.FindGameObjectWithTag("RespawnPos").transform.position;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void MainMenu()
    {

        int sceneNum = SceneManager.GetActiveScene().buildIndex;

            Destroy(GameObject.FindGameObjectWithTag("Canvas"));
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            Destroy(GameObject.FindGameObjectWithTag("MainCamera"));
            Destroy(GameObject.FindGameObjectWithTag("ShootingDir"));
            Destroy(GameObject.FindGameObjectWithTag("EventController"));

        SceneManager.LoadScene(0);

    }

    public void VolumeChange()
    {

        volumeSliderValue = volumeSlider.GetComponent<Slider>().value;

    }

    private void Start()
    {

        mainCamAudio = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>();

    }

    private void Update()
    {

        foreach (GameObject Element in AudioSourcesInScene)
        {

            Element.GetComponent<AudioSource>().volume = volumeSliderValue;

        }

        mainCamAudio.volume = volumeSliderValue;

        AudioSourcesInScene.Add(GameObject.FindGameObjectWithTag("Enemy"));

    }

}
