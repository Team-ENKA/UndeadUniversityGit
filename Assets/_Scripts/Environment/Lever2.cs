using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever2 : MonoBehaviour
{

    public Transform doorTransform;

    private GameObject cureCounter;
    private CureCounter cureCounterScript;
    private int cd = 0;

    public void Start()
    {
        cureCounter = GameObject.FindGameObjectWithTag("CureCounter");
        cureCounterScript = cureCounter.GetComponent<CureCounter>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && cd == 0)
        {
            if (cureCounterScript.counter < 18)
            {
                Debug.Log("Cure more zombies, the door is locked");
            }
            if (cureCounterScript.counter >= 18)
            {
                Debug.Log("Lever Pull");
                cd++;                                                               //Increase cooldown so door opens only once
                float rotateDoorTo = doorTransform.rotation.eulerAngles.z + 90f;    //Rotation amount (90 degrees)
                doorTransform.rotation = Quaternion.Euler(0, 0, rotateDoorTo);      //Rotate door along z axis
            }
        }
    }
}
