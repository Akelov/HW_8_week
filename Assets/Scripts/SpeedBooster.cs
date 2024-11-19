using UnityEngine;

public class SpeedBooster : MonoBehaviour
{
    [SerializeField] private float _speedBoostValue;

    public void IncreaseSpeed(GameObject owner)
    {
        WalkPlayer walkPlayer = owner.GetComponent<WalkPlayer>();

        if (walkPlayer == null)
        {
            Debug.LogError($"WalkPlayer is null - {GetType().Name}");
            return;
        }

        walkPlayer.Speed += _speedBoostValue;
    }
}
