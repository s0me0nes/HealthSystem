using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthSmoothSliderView : HealthSliderView
{
    private Coroutine _coroutine;

    protected override void ShowHealth(int current, int max)
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

        _coroutine = StartCoroutine(MoveSlider(current, max));
    }

    private IEnumerator MoveSlider(int current, int max)
    {
        if (max <= 0)
        {
            yield break;
        }

        float startPoint = Slider.value;
        float endPoint = current / (float)max;

        float currentTime = 0;
        float maxTime = 0.5f;
        float progress;

        while (currentTime < maxTime)
        {
            currentTime += Time.deltaTime;
            progress = currentTime / maxTime;
            Slider.value = Mathf.Lerp(startPoint, endPoint, progress);

            yield return null;
        }
    }
}

