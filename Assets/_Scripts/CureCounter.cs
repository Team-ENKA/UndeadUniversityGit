using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CureCounter : MonoBehaviour
{
    public int counter;

    public void CounterIncrease()
    {
        counter++;
        Debug.Log("Counter is at: " + counter);
    }
}
