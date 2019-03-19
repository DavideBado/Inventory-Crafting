using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickCraftable : MonoBehaviour, ICraftable
{

    public string effect = "";

    public IEndDragHandler GetEffects
    {
        get
        {
            return IEndDragHandler.effect2;
        }
    }

    public string GetCraftEffect()
    {
        return effect.ToUpper();
    }

}
