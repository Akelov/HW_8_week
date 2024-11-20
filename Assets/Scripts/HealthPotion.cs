using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    [SerializeField] private int _boostValue;

    public void IncreaseHealth(GameObject owner)
    {
        IHealthRestorer healthRestorer = owner.GetComponent<IHealthRestorer>();
        if (healthRestorer != null)
        {
            healthRestorer.RestoreHealth(_boostValue);
        }
        else
        {
            Debug.LogError($"HealthRestorer is null - {GetType().Name}");
            return;
        }
    }
}
