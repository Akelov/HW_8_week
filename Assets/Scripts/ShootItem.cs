using System.Data.Common;
using UnityEngine;

public class ShootItem : Item
{
    [SerializeField] private Bullet _bulletPrefab;

    public override bool CanPickUp(GameObject owner)
    {
        return owner.GetComponentInChildren<ShootPointMarker>() != null;
    }

    public override void Use(GameObject owner)
    {
        base.Use(owner);

        Transform shootPointMarkerPosition = owner.GetComponentInChildren<ShootPointMarker>().transform;

        Bullet bullet = Instantiate(_bulletPrefab, shootPointMarkerPosition.position, Quaternion.identity, null);;
        Debug.Log(shootPointMarkerPosition.forward);

        if (bullet == null)
            Debug.LogError("Bullet is null");
        else
            bullet.Launch(shootPointMarkerPosition.forward);

    }
}
