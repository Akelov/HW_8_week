using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    [SerializeField] private int _boostValue;

    public void IncreaseHealth(GameObject owner)
    {
        Health health = owner.GetComponent<Health>();
        
        if(health == null)
        {
            Debug.LogError($"Health is null - {GetType().Name}");
            return;
        }

        health.CurrentHealth += _boostValue;
    }
}
