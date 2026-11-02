using UnityEngine;

public abstract class HealthBarView : MonoBehaviour
{
    [SerializeField] protected Health Health;

    private void OnEnable()
    {
        Health.HealthChanged += ShowHealth;
        ShowHealth(Health.CurrentHealth, Health.MaxHealth);
    }

    private void OnDisable()
    {
        Health.HealthChanged -= ShowHealth;
    }

    protected abstract void ShowHealth(int current, int max);
}
