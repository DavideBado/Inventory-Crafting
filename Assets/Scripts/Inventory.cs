using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private const int Slots = 9;

    private List<IInventoryItem> mItems = new List<IInventoryItem>();

    public event EventHandler<InventoryEventArg> ItemAdded;
    public event EventHandler<InventoryEventArg> ItemRemoved;

    public void AddItem(IInventoryItem item) // Quando si aggiunge un elemento
    {
        if(mItems.Count < Slots) // Se hai ancora spazio
        {
            Collider collider = (item as MonoBehaviour).GetComponent<Collider>(); // Prendi il collider
            if (collider.enabled)
            {
                collider.enabled = false; // Spegnilo

                mItems.Add(item); // Aggiungi l'oggetto alla lista

                item.OnPickup();

                if(ItemAdded != null)
                {
                    ItemAdded(this, new InventoryEventArg(item));
                }
            }
        }
    }

    public void RemoveItem(IInventoryItem item)
    {
        if(mItems.Contains(item))
        {
            mItems.Remove(item);
        }

        Collider collider = (item as MonoBehaviour).GetComponent<Collider>();
        if(collider != null)
        {
            collider.enabled = true;
        }

        if(ItemRemoved != null)
        {
            ItemRemoved(this, new InventoryEventArg(item));
        }
    }

}
