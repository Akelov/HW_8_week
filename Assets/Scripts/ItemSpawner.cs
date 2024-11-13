using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _itemPrefab;

    private ISpawningBehaviour _spawning;

    private void Awake()
    {
        _spawning = gameObject.AddComponent<Spawning>();
    }

    private void Start()
    {
        SpawningItem();
    }

    private void SpawningItem()
    {
        _spawning.Spawn(_itemPrefab);
    }

    private void Reset()
    {
        SpawningItem();
    }
}
