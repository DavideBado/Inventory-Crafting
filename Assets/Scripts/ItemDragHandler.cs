using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDragHandler : MonoBehaviour, IDragHandler // Qui dovrebbe esserci IEndDragHandler, ma fa lo stronzo

{
    public IInventoryItem Item { get; set; }
    public void OnDrag(PointerEventData eventData) // Quando dragga
    {
        transform.position = Input.mousePosition; // Segui
    }  
}
