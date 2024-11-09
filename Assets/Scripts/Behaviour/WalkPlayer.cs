using UnityEngine;

//класс описывающий логику хождения игрока, то есть логику управления сущщностью
public class WalkPlayer : MonoBehaviour, IMovementBehaviour
{
    private CharacterController _characterController;
    private float _speed;
    private float _deadZone;

    public float DeadZone 
    {
        get => _deadZone;
        set
        {
            if (value <= 0)
            {
                _deadZone = 0.1f;
                Debug.LogError("DeadZone, в классе WalkPlayer, не может быть меньше либо равно нуля");
                Debug.Log("DeadZone равна дефолтному значению - 0.1");
            }else _deadZone = value;
        }
    }

    public float Speed 
    {
        get => _speed;
        set
        {
            if(value < 0)
            {
                _speed = 0;
                Debug.LogError("В свойство Speed в классе WalkPlayers передается склорость меньше 0");
                Debug.Log("В свойство переадалсь скорость со значением 0");
            }else _speed = value;
        }
    } 

    public void Move()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        if (input.magnitude <= _deadZone) return;

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
        _characterController.Move(direction.normalized * _speed * Time.deltaTime);
    }
}
