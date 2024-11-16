using UnityEngine;

public class SpeedBooster : MonoBehaviour
{
    [SerializeField] private float _speetBoostValue = 10f;
    [SerializeField] private GameObject _gameObject;

    private void IncreaseSpeed()
    {
        WalkPlayer walkPlayer = _gameObject.GetComponent<WalkPlayer>();
        if (walkPlayer == null)
        {
            Debug.LogError($"WalkPlayer is null - {GetType().Name}");
            return;
        }

        walkPlayer.Speed += _speetBoostValue;
    }
}
