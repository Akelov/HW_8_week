using UnityEngine;

public class Health : MonoBehaviour
{
    private int _maxHealth;
    private int _currentHealth;

    public void Initialize(int valueHealth)
    {
        CurrentHealth = ValueHealth = valueHealth;
    }

    public int ValueHealth
    {
        get => _maxHealth;
        private set
        {
            if (value <= 0)
            {
                Debug.LogError($"В свойство ValueHealt, в классе {GetType().Name} задается значние меньше либо равно 0");
                return;
            }
            
            _maxHealth = value;
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
