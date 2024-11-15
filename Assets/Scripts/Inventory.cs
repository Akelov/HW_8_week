using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Item _item;

    private bool HasItem() => _item != null;

    public Item GetItem() // забрали item
    {
        if (HasItem() == false)
        {
            Debug.LogError("Нет предмета!");
            return null;
        }
        Item selectItem = _item;
        _item = null;
        return selectItem;
    }

    public void PutItem(Item item)
    {
        if(HasItem() == true)
        {
            Debug.LogError("Уже есть предмет.");
            return;

        }
        _item = item;
    }   
}
