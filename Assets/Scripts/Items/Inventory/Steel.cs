using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ******** VEDI STONE.CS ************
public class Steel : MonoBehaviour, IInventoryItem 
{
    public GameObject GameObject
    {
        get
        {
            return gameObject;
        }
    }

    public string Name
    {
        get
        {
            return "Steel";
        }
    }

    public Sprite _Image = null;

    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }



    public void OnPickup()
    {
        gameObject.SetActive(false);
    }

   
}
