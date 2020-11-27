using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Lever2 : MonoBehaviour
{

    public Transform doorTransform;
    public int requiredCures = 18;
    public GameObject requirementCanvas;
    public string have;
    public string need;
    public TextMeshPro counterVsReq;
    public SpriteRenderer upSprite;
    public SpriteRenderer downSprite;

    private GameObject cureCounter;
    private CureCounter cureCounterScript;
    private int cd = 0;
    private float counter = 0;

    public void Start()
    {
        cureCounter = GameObject.FindGameObjectWithTag("CureCounter");
        cureCounterScript = cureCounter.GetComponent<CureCounter>();
        requirementCanvas.SetActive(false);
        downSprite.enabled = false;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && cd == 0)
        {
            if (cureCounterScript.counter < requiredCures)
            {
                NotEnough();
            }
            if (cureCounterScript.counter >= requiredCures)
            {
                Debug.Log("Lever Pull");
                cd++;                                                               //Increase cooldown so door opens only once
                float rotateDoorTo = doorTransform.rotation.eulerAngles.z + 90f;    //Rotation amount (90 degrees)
                doorTransform.rotation = Quaternion.Euler(0, 0, rotateDoorTo);      //Rotate door along z axis
                downSprite.enabled = true;                                          //Flips the switch downwards
                upSprite.enabled = false;                                           //Disable current sprite
            }
        }
    }
    private void NotEnough()
    {
        counter = 3;
        counter -= Time.deltaTime;
        requirementCanvas.SetActive(true);
        need = requiredCures.ToString();                        //need = predefined requirement, here 18
        have = cureCounterScript.counter.ToString();            //have = current amount of cures
        counterVsReq.text = have + " / " + need;                //have cured / need cured
   
        Debug.Log("Cure more zombies, the door is locked");
        /*
         * Change sprite from Up to Down
         * show image Gingerbreadman
         * Play sound Gadunk
        */
        if (counter <= 0)
        {
            requirementCanvas.SetActive(false);
        }
    }
}
