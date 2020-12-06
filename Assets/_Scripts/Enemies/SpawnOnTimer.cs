using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnTimer : MonoBehaviour
{
    [SerializeField] GameObject zombieAi;
    private int xPos;
    private int yPos;
    private int enemyCount;
    public int maxEnemies = 10;
    public float timeBetweenSpawn = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(EnemySpawn());
        }
    }
    IEnumerator EnemySpawn()
    {
        while (enemyCount < maxEnemies)
        {
            xPos = UnityEngine.Random.Range(-733, -251);                                //These positions pick a random spot in the bloody hallway
            yPos = UnityEngine.Random.Range(35, 63);                                    //
            Instantiate(zombieAi, new Vector3(xPos, yPos, 0), Quaternion.identity);     
            yield return new WaitForSeconds(timeBetweenSpawn);
            enemyCount++;
        }
    }
}
