using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieInfectionBar : MonoBehaviour
{
    public Slider zombieInfectionSlider;
    public Gradient gradient;
    public Image DamageFill;
    public void SetMaxHealth(int health)
    {
        zombieInfectionSlider.maxValue = health;
        zombieInfectionSlider.value = health;

        DamageFill.color = gradient.Evaluate(1f);
    }
    public void SetHealth(int health)
    {
        zombieInfectionSlider.value = health;

        DamageFill.color = gradient.Evaluate(zombieInfectionSlider.normalizedValue);
    }
}
