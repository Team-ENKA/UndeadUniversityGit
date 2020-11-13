using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCounter : MonoBehaviour
{
    public int ammo;
    public int ammoBag;
    public Text Text;
    public Shooting hasAmmo;

    // Start is called before the first frame update
    void Start()
    {

        //Gets the text component
        Text = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

        Text.text = ("Ammo: " + ammo + " / " + ammoBag);

        if (Input.GetKeyDown("r"))
        {
            Reload();
        }

    }

    private void Reload()
    {
        
        if (ammoBag > 30)
        {
            int ammoNeeded = ammo - 30;
            ammo -= ammoNeeded;
            ammoBag += ammoNeeded;

        } else
        {

            if (ammoBag > ammo)
            {

                int ammoNeeded = ammo - 30;
                ammo -= ammoNeeded;
                ammoBag += ammoNeeded;

            }

            if (ammo > ammoBag)
            {

                ammo = ammo + ammoBag;
                ammoBag = ammoBag - ammoBag;

            }

        }

    }

    //Adds a magazine whenever the AddKey method is invoked
    public void AddMag()
    {

        ammoBag += 30;

    }

    //This method is used when the player interacts with a locked door. If the player has a key, it will remove 1 key, and activate the method for the doors script
    public void AmmoCheck()
    {

        if (ammo >= 1f)
        {

            hasAmmo.Shoot();
            ammo--;

        }

    }
}
