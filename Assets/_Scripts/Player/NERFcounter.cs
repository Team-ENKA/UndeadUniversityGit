using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NERFcounter : MonoBehaviour
{
    public int NERFammo;
    public int NERFammoBag;
    public Text NERFText;
    public Shooting NERFhasAmmo;


    public void NERFAddMag()
    {

        NERFammoBag += 10;

    }

    public void AmmoCheck()
    {

        if (NERFammo >= 1f)
        {

            NERFhasAmmo.Shoot();
            NERFammo--;

        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NERFText.text = ("Magazine: " + NERFammo + " / Ammunition" + NERFammoBag);
    }
}
