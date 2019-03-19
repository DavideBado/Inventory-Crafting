using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemOnClick : MonoBehaviour // Visto che il drag non va, ci tocca cliccare
{
   public Crafter crafter;
   public void OnClick(ItemDragHandler itemDrag)
    {
        if (crafter != null && crafter.CraftingCanvas.enabled == true) // Se stai craftando
        {
            ItemDragHandler itemDragHandler = gameObject.transform.GetComponentInChildren<ItemDragHandler>();

            //IInventoryItem item = itemDragHandler.Item;
            IInventoryItem item = itemDrag.Item; // Prendi l'oggetto scelto

            crafter.SelectItem(item); // Sacrificalo 
        }
    }
}
