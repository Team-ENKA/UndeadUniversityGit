using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnTimer : MonoBehaviour
{
    [SerializeField] GameObject zombieAi;
    public float timerKeeper = 0;
    [SerializeField] Transform pos1;
    [SerializeField] Transform pos2;
    [SerializeField] Transform pos3;
    [SerializeField] Transform pos4;
    [SerializeField] Transform pos5;
    [SerializeField] Transform pos6;
    [SerializeField] Transform pos7;
    [SerializeField] Transform pos8;
    [SerializeField] Transform pos9;
    [SerializeField] Transform pos10;
    bool spawned;

    void Update()
    {
        
        timerKeeper += Time.deltaTime;
        int timer = Convert.ToInt32(timerKeeper);
        if (timer==1) 
        {
            Instantiate(zombieAi, pos1);
        }
        if (timer==2)
        {
            Instantiate(zombieAi, pos2);
        }
        if (timer==3)
        {
            Instantiate(zombieAi, pos3);
        }
        if (timer==4)
        {
            Instantiate(zombieAi, pos4);
        }
        if (timer==5)
        {
            Instantiate(zombieAi, pos5);
        }
        if (timer==6)
        {
            Instantiate(zombieAi, pos6);
        }
        if (timer==7)
        {
            Instantiate(zombieAi, pos7);
        }
        if (timer==8)
        {
            Instantiate(zombieAi, pos8);
        }
        if (timer == 9)
        {
            Instantiate(zombieAi, pos9);
        }
        if (timer == 10)
        {
            Instantiate(zombieAi, pos10);
        }
    }
}
