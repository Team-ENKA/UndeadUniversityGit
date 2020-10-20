using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieInfectionFill : MonoBehaviour
{
    public Image InfectionFill;
    public float Fill;

    // Start is called before the first frame update
    void Start()
    {
        Fill = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Fill > 0)
        {
            Fill -= Time.deltaTime * 0.2f;
        }
        InfectionFill.fillAmount = Fill;
    }
}
