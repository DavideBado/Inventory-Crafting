using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemOnClick : MonoBehaviour
{
   public Crafter crafter;
   public void OnClick(ItemDragHandler itemDrag)
    {
        if (crafter != null && crafter.CraftingCanvas.enabled == true)
        {
            ItemDragHandler itemDragHandler = gameObject.transform.GetComponentInChildren<ItemDragHandler>();

            //IInventoryItem item = itemDragHandler.Item;
            IInventoryItem item = itemDrag.Item;

            crafter.SelectItem(item);
        }
    }
}
