using UnityEngine;

public class Spawning : MonoBehaviour, ISpawningBehaviour
{
    public void Spawn(GameObject prefab)
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
