using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteelCraftable : MonoBehaviour, ICraftable
{

    public string effect = "";

    public IEndDragHandler GetEffects
    {
        get
        {
            return IEndDragHandler.effect3;
        }
    }

    public string GetCraftEffect()
    {
        return effect.ToUpper();
    }

}
