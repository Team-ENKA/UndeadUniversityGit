using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnTimer : MonoBehaviour
{
    [SerializeField] GameObject zombieAi;
    public float timer = 0;
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

    void Update()
    {
        timer += Time.deltaTime;
        if (0 < timer && timer > 1) 
        {
            Instantiate(zombieAi, pos1);
        }
        if (0 < timer && timer > 1)
        {
            Instantiate(zombieAi, pos2);
        }
        if (0 < timer && timer > 1)
        {
            Instantiate(zombieAi, pos3);
        }
        if (0 < timer && timer > 1)
        {
            Instantiate(zombieAi, pos4);
        }
        if (0 < timer && timer > 1)
        {
            Instantiate(zombieAi, pos5);
        }
        if (0 < timer && timer > 1)
        {
            Instantiate(zombieAi, pos6);
        }
        if (0 < timer && timer > 1)
        {
            Instantiate(zombieAi, pos7);
        }
        if (0 < timer && timer > 1)
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
