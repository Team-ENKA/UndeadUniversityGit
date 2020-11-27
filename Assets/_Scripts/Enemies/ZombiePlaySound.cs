using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiePlaySound : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip zombieHurt;
    public AudioClip zombieAmbient1;
    public AudioClip zombieAmbient2;
    public AudioClip zombieAmbient3;
    private float cooldownTime = 2;

    // Start is called before the first frame update
    void Start()
    {

        audioSource = GetComponent<AudioSource>();

    }

    private void Update()
    {

        cooldownTime = cooldownTime - Time.deltaTime;

        if(cooldownTime <= 0)
        {

            zombieAmbient(Random.Range(1, 4));
            cooldownTime = Random.Range(8, 32);

        }

    }

    public void Hurt()
    {

        audioSource.clip = zombieHurt;
        audioSource.Play();

    }

    public void zombieAmbient(int clip)
    {

        //use else if(clip == clipNumber)
        //        audioSource.clip = nameOfClip;
        if (clip == 1)
            audioSource.clip = zombieAmbient1;
        else if(clip == 2)
            audioSource.clip = zombieAmbient2;
        else if (clip == 3)
            audioSource.clip = zombieAmbient3;

        audioSource.Play();

    }

}
