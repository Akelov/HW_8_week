using System;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    private float DeadZone = 0.1f;

    [SerializeField] private float _speed;
    private Player _player;
    private WalkPlayer _walkPlayer;
    private PullToMyselfItem _pullToMyselfItem;

    private void Awake()
    {
        SetComponents();
        CheckForNullReferenceException();

        _player.Initialization(_walkPlayer, _pullToMyselfItem);

        SetValues();
    }


    private void Update()
    {
        _player.Walk();
    }

    private void SetComponents()
    {
        _player = gameObject.AddComponent<Player>();
        _walkPlayer = gameObject.AddComponent<WalkPlayer>();
        _pullToMyselfItem = gameObject.AddComponent<PullToMyselfItem>();
    }

    private void CheckForNullReferenceException()
    {
        if (_player == null)
        {
            Debug.LogError("Player is null");
        }
        if (_walkPlayer == null)
        {
            Debug.LogError("WalkPlayer is null");
        }
    }

    private void SetValues()
    {
        _walkPlayer.Speed = _speed;
        _walkPlayer.DeadZone = DeadZone;
    }
}
