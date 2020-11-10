using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.CompilerServices;

public class Workbench : MonoBehaviour
{
    public GameObject craftScreen;
    public Canvas insuffMats;
    public GameObject pressSpace;

    public PoleBool poleBool;
    public TankBool tankBool;
    public AntibacSledge antibacSledge;

    private float cooldownsMats;
    private int sledgeActive;
    private float spaceActive;
    

    private void Start()
    {
        craftScreen.SetActive(false);
        pressSpace.SetActive(true);
        sledgeActive = 0;
        spaceActive = 0;
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        //If you're lacking both materials
        if (collision.gameObject.tag == "Player" && poleBool.isActive == true && tankBool.isActive == true)
        {
            insuffMats.gameObject.SetActive(true);
            cooldownsMats = 2;
            Debug.Log("Insufficient Materials");
        }

        //If you have one material
        if (collision.gameObject.tag == "Player" && poleBool.isActive == true && tankBool.isActive == false)
        {
            insuffMats.gameObject.SetActive(true);
            cooldownsMats = 2;
            Debug.Log("Insufficient Materials");
        }
        //If you have one material
        if (collision.gameObject.tag == "Player" && poleBool.isActive == false && tankBool.isActive == true)
        {
            insuffMats.gameObject.SetActive(true);
            cooldownsMats = 2;
            Debug.Log("Insufficient Materials");
        }

        //if you have both materials
        if (collision.gameObject.tag == "Player" && poleBool.isActive == false && tankBool.isActive == false && sledgeActive == 0)
        {
            craftScreen.SetActive(true);
            insuffMats.gameObject.SetActive(false);
            sledgeActive++;
            Debug.Log("CraftScreen active");
        }
    }
    public void CraftClick()
    {
        antibacSledge.sledgeCraft=true;
        craftScreen.SetActive(false);
        pressSpace.SetActive(true);
        spaceActive = 5;
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