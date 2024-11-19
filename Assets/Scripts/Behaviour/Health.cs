using UnityEngine;

public class Health : MonoBehaviour
{
    private int _valueHealth;
    private int _currentHealth;

    public void Initialize(int valueHealth)
    {
        CurrentHealth = ValueHealth = valueHealth;
    }

    public int ValueHealth
    {
        get => _valueHealth;
        private set
        {
            if (value <= 0)
            {
                Debug.LogError($"� �������� ValueHealt, � ������ {GetType().Name} �������� ������� ������ ���� ����� 0");
                return;
            }
            
            _valueHealth = value;
        }
    }

    public int CurrentHealth
    {
        get => _currentHealth;
        set
        {
            if (value < 0)
            {
                _currentHealth = 0;
            }
            else
            {
                _currentHealth += value;
            }
        }
    }
}
