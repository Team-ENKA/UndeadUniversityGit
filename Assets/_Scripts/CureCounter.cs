using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CureCounter : MonoBehaviour
{
    [SerializeField] private int counter;

    public void CounterIncrease()
    {
        counter++;
        Debug.Log(counter);
    }
}
