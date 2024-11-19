using UnityEngine;

public class SpeedBoostItem : Item
{
    [SerializeField] private SpeedBooster _speedBoosterPrefab;

    public override bool CanPickUp(GameObject owner)
    {
        return true;
    }

    public override void Use(GameObject owner)
    {
        base.Use(owner);

        if(_speedBoosterPrefab == null)
        {
            Debug.LogError($"SpeedBooster is null - {GetType().Name}");
            return;
        }

        _speedBoosterPrefab.IncreaseSpeed(owner);
    }
}
