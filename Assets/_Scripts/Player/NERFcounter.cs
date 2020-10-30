using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NERFcounter : MonoBehaviour
{
    public int NERFammo;
    public Text NERFText;
    public Shooting NERFhasAmmo;


    public void NERFAddMag()
    {

        NERFammo += 20;

    }

    public void AmmoCheck()
    {

        if (NERFammo >= 1f)
        {

            NERFhasAmmo.NERFShoot();
            NERFammo--;

        }

    }

    void Update()
    {
        NERFText.text = ("NERF Clip: " + NERFammo);
    }
}
