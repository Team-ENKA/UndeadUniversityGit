using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockage : MonoBehaviour
{
    public GameObject blockageParent;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && collision.gameObject.tag == "Enemy")
        {
            blockageParent.SetActive(true);
        }
        if (collision.gameObject.tag != "Enemy")
        {
            blockageParent.SetActive(false);
        }
    }
}
