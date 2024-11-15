using UnityEngine;

public class Health 
{
    private int _valueHealth;
    private int _currentHealth;

    public Health(int valueHealth)
    {
        ValueHealth = valueHealth;
        CurrentHealth = valueHealth;
    }

    public int ValueHealth
    {
        get => _valueHealth;
        set
        {
            if (value <= 0)
            {
                Debug.LogError($"� �������� ValueHealt, � ������ {GetType().Name} �������� ������� ������ ���� ����� 0");
            }
            else _valueHealth = value;
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

                if(_currentHealth > _valueHealth)  
                    _currentHealth = _valueHealth;
            }
        }
    }
}
