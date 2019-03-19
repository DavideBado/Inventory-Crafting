using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour, IInventoryItem // Questo oggetto deve avere:
{
    public string Name // Un nome
    {
        get
        {
            return "Stone";
        }
    }

    public Sprite _Image = null;

    public Sprite Image // Una sua rappresentazione 2D
    {
        get
        {
            return _Image;
        }
    }

    public GameObject GameObject // Il suo gameObject
    {
        get
        {
            return gameObject;
        }
    }

    public void OnPickup() // Quando viene raccolto
    {
        gameObject.SetActive(false); // Si spegne
    }

   
}
