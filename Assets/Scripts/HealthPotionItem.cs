using UnityEngine;

public class HealthPotionItem : Item
{
    [SerializeField] private HealthPotion _healthPotionPrefab;

    public override bool CanPickUp(GameObject owner)
    {
        return true;
    }

    public override void Use(GameObject owner)
    {
        base.Use(owner);

        if(_healthPotionPrefab == null)
        {
            Debug.LogError($"HealthPotionPrefab is null - {GetType().Name}");
            return;
        }

        _healthPotionPrefab.IncreaseHealth(owner);
    }
}
