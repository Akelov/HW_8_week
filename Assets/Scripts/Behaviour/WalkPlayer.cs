using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkPlayer : MonoBehaviour, IMovementBehaviour
{
    private CharacterController _characterController;

    public float DeadZone { get; set; } = 0.1f;
    public float Speed { get; set; } = 10f;

    public void Move()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        if (input.magnitude <= DeadZone) return;

        ProcesMoveTo(input);
        ProcesRotateTo(input);
    }

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void ProcesRotateTo(Vector3 direction)
    {
        Quaternion quaternion = Quaternion.LookRotation(direction);
        transform.rotation = quaternion;
    }

    private void ProcesMoveTo(Vector3 direction)
    {
        _characterController.Move(direction.normalized * Speed * Time.deltaTime);
    }
}
