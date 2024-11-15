using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Launch(Vector3 direction)
    {
        _rigidbody.AddForce(direction * _force, ForceMode.Impulse);
    }
}
