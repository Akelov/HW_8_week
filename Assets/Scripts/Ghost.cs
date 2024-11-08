using System;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    private float DeadZone = 0.1f;

    [SerializeField] private float _speed;
    private Player _player;
    private WalkPlayer walkPlayer;

    private void Awake()
    {
        SetComponents();
        CheckForNullReferenceException();

        _player.Initialization(walkPlayer);

        SetValues();
    }


    private void Update()
    {
        _player.Walk();
    }

    private void SetComponents()
    {
        _player = gameObject.AddComponent<Player>();
        walkPlayer = gameObject.AddComponent<WalkPlayer>();
    }

    private void SetValues()
    {
        walkPlayer.Speed = _speed;
        walkPlayer.DeadZone = DeadZone;
    }

    private void CheckForNullReferenceException()
    {
        if (_player == null)
        {
            Debug.LogError("Player is null");
        }
        if (walkPlayer == null)
        {
            Debug.LogError("WalkPlayer is null");
            return;
        }
    }
}
