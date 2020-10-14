using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieDamageBar : MonoBehaviour
{
    public Slider zombieDamageSlider;
    public Gradient gradient;
    public Image DamageFill;
    public void SetMaxHealth(int health)
    {
        zombieDamageSlider.maxValue = health;
        zombieDamageSlider.value = health;

        DamageFill.color = gradient.Evaluate(1f);
    }
    public void SetHealth(int health)
    {
        zombieDamageSlider.value = health;

        DamageFill.color = gradient.Evaluate(zombieDamageSlider.normalizedValue);
    }
}
