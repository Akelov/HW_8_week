using System;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    private float DeadZone = 0.1f;
    [SerializeField] private Health _health;
    [SerializeField] private WalkPlayer _walkPlayer;
    [SerializeField] private ItemCollector _itemCollector;
    [SerializeField] private Transform _itemHolderPoint;
    private ItemHandler _itemHandler;

    [SerializeField] private int _healthValue;

    private void Awake()
    {
        SetComponents();
        CheckForNullReferenceException();
        SetValues();
    }


    private void Update()
    {
        Debug.Log($"Çהמנמגüו: {_health.CurrentHealth}");

        DownKeyF();

        _walkPlayer.Move();
    }

    private void DownKeyF()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (_itemHandler.CanUseItem())
            {
                _itemHandler.UseItem();
            }
        }
    }

    private void SetComponents()
    {
        Inventory inventory = new Inventory(_itemHolderPoint);
        _walkPlayer = GetComponent<WalkPlayer>();
        _health = new Health(_healthValue);
        _itemCollector.Initialize(inventory);
        _itemHandler = new ItemHandler(inventory, gameObject);
    }

    private void CheckForNullReferenceException()
    {
        if (_walkPlayer == null)
            Debug.LogError("WalkPlayer is null");
        if (_health == null)
            Debug.LogError("Health is null");
    }

    private void SetValues()
    {
        _walkPlayer.DeadZone = DeadZone;
    }
}
