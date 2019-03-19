using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour, IInventoryItem 
{
    public string Name
    {
        get
        {
            return "Stone";
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

    public GameObject GameObject
    {
        get
        {
            return gameObject;
        }
    }

    public void OnPickup()
    {
        gameObject.SetActive(false);
    }

   
}
