using UnityEngine;

public class Player : MonoBehaviour, IWalker
{
    private IMovementBehaviour _movementBehaviour;

    public void Initialization(IMovementBehaviour movementBehaviour)
    {
        _movementBehaviour = movementBehaviour;
    }

    public void Walk()
    {
        _movementBehaviour.Move();
    }
}
