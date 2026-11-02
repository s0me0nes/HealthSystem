using UnityEngine;
using UnityEngine.UI;

public class HealthTextView : HealthBarView
{
    [SerializeField] private Text _healthTxt;

    protected override void ShowHealth(int current, int max)
    {
        _healthTxt.text = current + "/" + max;
    }
}
