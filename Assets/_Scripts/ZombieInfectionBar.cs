using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieInfectionBar : MonoBehaviour
{
    public Slider zombieInfectionSlider;
    public Gradient gradient;
    public Image InfectionFill;
    public void SetMaxHealth(int health)
    {
        zombieInfectionSlider.maxValue = health;
        zombieInfectionSlider.value = health;

        InfectionFill.color = gradient.Evaluate(1f);
    }
    public void SetHealth(int health)
    {
        zombieInfectionSlider.value = health;

        InfectionFill.color = gradient.Evaluate(zombieInfectionSlider.normalizedValue);
    }
}
