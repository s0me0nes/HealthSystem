using UnityEngine;
using UnityEngine.UI;

public class HealthSliderView : HealthBarView
{
    [SerializeField] protected Slider Slider;

    protected override void ShowHealth(int current, int max)
    {
        if (max <= 0)
        {
            return;
        }

        Slider.value = current / (float)max;
    }
}