using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.CompilerServices;

public class Workbench2 : MonoBehaviour
{
    public GameObject craftScreen;
    public Canvas insuffMats;
    public GameObject pressSpace;

    public GunpowderBool gunpowderBool;
    public RocketBool rocketBool;
    public GameObject fireworks;

    private float cooldownsMats;
    private int fireWorksActive;
    private float spaceActive;


    private void Start()
    {
        fireworks.SetActive(false);
        craftScreen.SetActive(false);
        pressSpace.SetActive(true);
        fireWorksActive = 0;
        spaceActive = 0;
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        //If you're lacking both materials
        if (collision.gameObject.tag == "Player" && gunpowderBool.isActive == true && rocketBool.isActive == true)
        {
            insuffMats.gameObject.SetActive(true);
            cooldownsMats = 2;
            Debug.Log("Insufficient Materials");
        }

        //If you have one material
        if (collision.gameObject.tag == "Player" && gunpowderBool.isActive == true && rocketBool.isActive == false)
        {
            insuffMats.gameObject.SetActive(true);
            cooldownsMats = 2;
            Debug.Log("Insufficient Materials");
        }
        //If you have one material
        if (collision.gameObject.tag == "Player" && gunpowderBool.isActive == false && rocketBool.isActive == true)
        {
            insuffMats.gameObject.SetActive(true);
            cooldownsMats = 2;
            Debug.Log("Insufficient Materials");
        }

        //if you have both materials
        if (collision.gameObject.tag == "Player" && gunpowderBool.isActive == false && rocketBool.isActive == false && fireWorksActive == 0)
        {
            craftScreen.SetActive(true);
            insuffMats.gameObject.SetActive(false);
            fireWorksActive++;
            Debug.Log("CraftScreen active");
        }
    }
    public void CraftClick()
    {
        fireworks.SetActive(true);
        craftScreen.SetActive(false);
        pressSpace.SetActive(true);
        spaceActive = 10;
        Debug.Log("CraftClick done");
    }
    private void Update()
    {
        cooldownsMats = cooldownsMats - Time.deltaTime;
        spaceActive = spaceActive - Time.deltaTime;

        if (spaceActive <= 0)
        {
            pressSpace.SetActive(false);
        }

        if (cooldownsMats <= 0)
        {
            insuffMats.gameObject.SetActive(false);
        }

    }
}