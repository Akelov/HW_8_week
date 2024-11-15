using UnityEngine;

public class Inventory
{
    private Transform _itemHolderPoint;
    private Item _item;

    public Inventory(Transform itemHolderPoint) => _itemHolderPoint = itemHolderPoint;

    public bool HasItem() => _item != null;

    public Item GetItem() // забрали item
    {
        if (HasItem() == false)
        {
            Debug.LogError("Нет предмета!");
            return null;
        }
        Item selectItem = _item;
        _item = null;
        _item.transform.SetParent(null);
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
        _item.transform.SetParent(_itemHolderPoint);
        _item.transform.localPosition = Vector3.zero;
    }   
}
