using UnityEngine;

public class Spawning : MonoBehaviour, ISpawningBehaviour
{
    private Vector3 _otherPosition = new Vector3(0, 0.5f, 0);
    private Quaternion _otherRotation = Quaternion.Euler(-90, 0, 0);

    public void Spawn(GameObject prefab)
    {
        Instantiate(prefab, transform.position + _otherPosition, _otherRotation);
    }
}
