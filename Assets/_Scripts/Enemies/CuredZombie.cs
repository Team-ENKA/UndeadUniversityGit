using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuredZombie : MonoBehaviour
{

    private SpriteRenderer Sprite;

    // Start is called before the first frame update
    void Start()
    {

        Sprite = gameObject.GetComponent<SpriteRenderer>();

    }

    //When cured, turns off the zombie sprite
    public void CuredZ()
    {

        Sprite.enabled = false;

    }

}
