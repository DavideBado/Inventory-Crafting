using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInventoryItem
{
    GameObject GameObject { get; } // Questo serve al crafter per come lo avevamo fatto in classe

    string Name { get; }

    Sprite Image { get; }

    void OnPickup();
    // Qui andranno aggiunte eventualmente le funzioni di drop/use
}

public class InventoryEventArg : EventArgs
{
    public InventoryEventArg(IInventoryItem item)
    {
        Item = item;
    }

    public IInventoryItem Item;
}

