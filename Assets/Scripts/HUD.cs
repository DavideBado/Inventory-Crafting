using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Transform inventoryPanel;
    public Inventory Inventory;
    // Start is called before the first frame update
    void Start()
    {
        Inventory.ItemAdded += InventoryScript_ItemAdded; // Segui l'evento oggetto aggiunto
        Inventory.ItemRemoved += Inventory_ItemRemoved; // Segui l'evento oggetto rimosso
    }

    private void InventoryScript_ItemAdded(object sender, InventoryEventArg e) // Quando viene aggiungo un oggetto dentro l'inventario
    {

        foreach (Transform slot in inventoryPanel) // Controlla gli slot dentro l'inventario
        {
            Transform imageTransform = slot.GetChild(0).GetChild(0); // Sfoglia i primi due figli dello slot
            Image image = imageTransform.GetComponent<Image>(); // Troverai un immagine
            ItemDragHandler itemDragHandler = imageTransform.GetComponent<ItemDragHandler>(); 

            if (!image.enabled) // Se l'immagine che hai trovato non è attiva
            {
                image.enabled = true; // Attivala
                image.sprite = e.Item.Image; // Metti come sprite lo sprite di ciò che è stato appena aggiunto

                itemDragHandler.Item = e.Item; // Salva cosa è stato aggiunto
                if (itemDragHandler.Item != null) // Se non ti sei dimenticato di salvare
                { break; } 
            }
            
        }
    }
    private void Inventory_ItemRemoved(object sender, InventoryEventArg e)
    {
        // Come add, ma spegne e azzera
        foreach (Transform slot in inventoryPanel)
        {
            Transform imageTransform = slot.GetChild(0).GetChild(0);
            Image image = imageTransform.GetComponent<Image>();
            ItemDragHandler itemDragHandler = imageTransform.GetComponent<ItemDragHandler>();

            if (itemDragHandler.Item.Equals(e.Item))
            {
                image.enabled = false;
                image.sprite = null;

                itemDragHandler.Item = null;

                break;
            }

        }
    }

}
