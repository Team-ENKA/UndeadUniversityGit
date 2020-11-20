using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlaySound : MonoBehaviour
{

    public AudioSource AS;
    public AudioClip sledgeSwing;
    public AudioClip playerDied;
    public AudioClip lockedDoor;

    // Start is called before the first frame update
    void Start()
    {

        AS = GetComponent<AudioSource>();

    }

    private void Update()
    {



    }

    public void AntibacSledgeSwing()
    {

        AS.clip = sledgeSwing;
        AS.Play();

    }

    public void LockedDoorSound()
    {

        AS.clip = lockedDoor;
        AS.Play();

    }

    // Update is called once per frame
    public void PlayerDied()
    {

        AS.clip = playerDied;
        AS.Play();

    }
}
