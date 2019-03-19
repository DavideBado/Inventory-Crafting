using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum IEndDragHandler { effect1, effect2, effect3 };


public interface ICraftable
{
    IEndDragHandler GetEffects { get; }
    string GetCraftEffect();
}

