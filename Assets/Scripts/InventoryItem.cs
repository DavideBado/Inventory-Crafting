using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInventoryItem
{
    GameObject gameObject { get; }

    string Name { get; }

    Sprite Image { get; }

    void OnPickup();
}

public class InventoryEventArg : EventArgs
{
    public InventoryEventArg(IInventoryItem item)
    {
        Item = item;
    }

    public IInventoryItem Item;
}

