using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Inventory Inventory;
    public Canvas CraftingUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Se è stato premuto il pulsante sinistro del mouse
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Fai partire un raggio dalla posizione del mouse
            RaycastHit hit;
            if (Physics.Raycast(ray.origin, ray.direction, out hit)) // Se entra in collisione con un oggetto
            {
                if (hit.collider.GetComponent<IInventoryItem>() != null)
                {
                    IInventoryItem item = hit.collider.GetComponent<IInventoryItem>();
                    if (item != null)
                    {
                        Inventory.AddItem(item);
                    }
                } else
                if (hit.collider.GetComponent<Crafter>() != null)
                {
                    Crafter crafter = hit.collider.GetComponent<Crafter>();

                    if (crafter != null)
                    {
                        CraftingUI.enabled = true;
                    }
                }
                  
            }
        }
    }

    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    IInventoryItem item = hit.collider.GetComponent<IInventoryItem>();

    //    if(item != null)
    //    {
    //        Inventory.AddItem(item);
    //    }
    //}
}
