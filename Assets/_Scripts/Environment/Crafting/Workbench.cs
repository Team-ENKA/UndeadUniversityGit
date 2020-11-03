using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Workbench : MonoBehaviour
{
    public Button craftButton;
    public GameObject craftScreen;
    public Canvas insuffMats;

    public PoleBool poleBool;
    public TankBool tankBool;
    public float cooldownsMats;
    public GameObject antibacSledge;


    void OnTriggerStay2D(Collider2D collision)
    {
        //If you're lacking both materials
        if (collision.gameObject.tag == "Player" && poleBool.isActive == true && tankBool.isActive == true)
        {
            insuffMats.gameObject.SetActive(true);
            cooldownsMats = 2;
            Debug.Log("Insufficient Materials");
        }

        //if you have both materials
        if (collision.gameObject.tag == "Player" && poleBool.isActive == false && tankBool.isActive == false)
        {
            craftScreen.SetActive(true);
            insuffMats.gameObject.SetActive(false);
            Debug.Log("CraftScreen active");
        }
    }
    public void CraftClick()
    {
        antibacSledge.SetActive(true);
        craftScreen.SetActive(false);
        Debug.Log("CraftClick done");
    }
    private void Update()
    {
        cooldownsMats = cooldownsMats - Time.deltaTime;

        if (cooldownsMats <= 0)
        {
            insuffMats.gameObject.SetActive(false);
        }
    }
}
