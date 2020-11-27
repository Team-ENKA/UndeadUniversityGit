using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowHHeal : MonoBehaviour
{

    private GameObject player;
    private BoHealthController health;
    public GameObject HtoHealText;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        health = player.GetComponent<BoHealthController>();
    }
    private void Update()
    {
        if(health.currentHealth > 15)
        {
            HtoHealText.SetActive(false);
        }
        if(health.currentHealth < 15)
        {
            HtoHealText.SetActive(true);
        }
    }
}
