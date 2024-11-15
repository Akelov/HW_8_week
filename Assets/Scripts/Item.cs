using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public abstract bool CanPickUp(GameObject owner);

    public virtual void Use(GameObject owner)
    {

    }
}
