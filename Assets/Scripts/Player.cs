using UnityEngine;

public class Player : MonoBehaviour, IWalker, IPicking
{
    private IMovementBehaviour _movementBehaviour;
    private IPickingBehaviour _pickingBehaviour;

    public void Initialization(IMovementBehaviour movementBehaviour, IPickingBehaviour pickingBehaviour)
    {
        _movementBehaviour = movementBehaviour;
        _pickingBehaviour = pickingBehaviour;
    }

    public void PickUp()
    {
        _pickingBehaviour.PickUp();
    }

    public void Walk()
    {
        _movementBehaviour.Move();
    }
}
