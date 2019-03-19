using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneCraftable : MonoBehaviour, ICraftable
{

    public string effect = "";

    public IEndDragHandler GetEffects
    {
        get
        {
            return IEndDragHandler.effect1;
        }
    }

    public string GetCraftEffect()
    {
        return effect.ToUpper();
    }

}
