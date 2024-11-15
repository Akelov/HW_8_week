using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private Item _item;
    [SerializeField] private Transform _itemHolderPoint;

    private void OnTriggerEnter(Collider other)
    { 
        Item item = other.GetComponent<Item>();
        if(item != null)
        {
            if(_item == null && item.CanPickUp(gameObject))
            {
                _item = item;
                _item.transform.SetParent(_itemHolderPoint);
                _item.transform.localPosition = Vector3.zero;
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(_item != null)
            {
                _item.Use(gameObject);
                Destroy(_item);
                _item = null;
            }
        }
    }
}
