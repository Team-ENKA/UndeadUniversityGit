using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuredHuman : MonoBehaviour
{

    private SpriteRenderer Sprite;

    // Start is called before the first frame update
    void Start()
    {

        Sprite = gameObject.GetComponent<SpriteRenderer>();

    }

    public void CuredH()
    {

        Sprite.enabled = true;

    }

}
