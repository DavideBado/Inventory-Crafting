using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafter : MonoBehaviour
{
    public Canvas CraftingCanvas;

    public GameObject object1;
    public GameObject object2;
    
    internal void SelectItem(IInventoryItem item) // Hai due slot per il crafting, è ora di riempirli
    {
        if (object1 == null) // Il primo è vuoto?
        {
            object1 = item.GameObject; // Mettici l'oggetto che ti sta passando l'inventario
        }
        else
        if (object2 == null) // Il primo era già pieno e il secondo è vuoto?
        {
            object2 = item.GameObject;
            CraftNow(); // Ora che anche il secondo slot è pieno crea qualcosa di nuovo
        } 
    }

    private void CraftNow()
    {if (object1 != null && object2 != null) // Assicurati che non ci siano errori
        {
            ICraftable Obj1 = object1.GetComponent<ICraftable>(); // Prendi solo quello che ti serve
            ICraftable Obj2 = object2.GetComponent<ICraftable>();

            if (Obj1 != null && Obj2 != null) // Un controllo in più non fa male
            {
                Debug.Log(Crafting(Obj1, Obj2)); // Stampa il risultato
            }
            else
            {
                Debug.Log("Not craftable"); // Cazzo hai messo dentro la forgia?
            }
        }
    }

    public string Crafting(ICraftable obj1, ICraftable obj2)
    {

        switch (obj1.GetEffects) // Prendi il libro delle ricette e divertiti
        {
            case IEndDragHandler.effect1:
                switch (obj2.GetEffects)
                {
                    case IEndDragHandler.effect2:
                        Debug.Log("Effetto1 + Effetto2");
                        break;
                    case IEndDragHandler.effect3:
                        Debug.Log("Effetto1 + Effetto3");
                        break;
                    default:
                        Debug.Log("Effetto non compatibile");
                        break;
                }
                break;
            case IEndDragHandler.effect2:
                switch (obj2.GetEffects)
                {
                    case IEndDragHandler.effect1:
                        Debug.Log("Effetto2 + Effetto1");
                        break;
                    case IEndDragHandler.effect3:
                        Debug.Log("Effetto2 + Effetto3");
                        break;
                    default:
                        Debug.Log("Effetto non compatibile");
                        break;
                }
                break;
            case IEndDragHandler.effect3:
                switch (obj2.GetEffects)
                {
                    case IEndDragHandler.effect1:
                        Debug.Log("Effetto3 + Effetto1");
                        break;
                    case IEndDragHandler.effect2:
                        Debug.Log("Effetto3 + Effetto2");
                        break;
                    default:
                        Debug.Log("Effetto non compatibile");
                        break;
                }
                break;
            default:
                break;
        }
        return string.Format("Effetto craft: {0} + {1} = ", obj1.GetCraftEffect(), obj2.GetCraftEffect());
        object1 = null; // Butta via gli ingredienti rimasti, l'utente sarà felice
        object2 = null;
    }
}

