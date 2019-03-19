using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemOnClick : MonoBehaviour
{
    public Crafter crafter;
   public void OnClick()
    {
        ItemDragHandler itemDragHandler = gameObject.transform.Find("ItemImage").GetComponent<ItemDragHandler>();

        IInventoryItem item = itemDragHandler.Item;

        crafter.SelectItem(item);
    }
}
