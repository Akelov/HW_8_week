using UnityEngine;

public class SpeedBoostItem : Item
{
    [SerializeField] private SpeedBooster _speedBoosterPrefab;

    public override bool CanPickUp(GameObject owner)
    {
        return true;
    }
}
