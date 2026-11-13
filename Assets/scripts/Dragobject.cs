
using UnityEngine;
using UnityEngine.InputSystem;  

public class Dragobject : MonoBehaviour
{
public delegate void DragEndedDelegate(Dragobject draggableObject);
public DragEndedDelegate dragEndedCallback;
private bool isDragging = false;
private Vector3 mouseDragStartPosition;
private Vector3 spriteDragStartPosition;


private void OnMouseDown ()
    {
       isDragging = true;
        mouseDragStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spriteDragStartPosition = transform.localPosition;
       
        
    }
private void OnMouseDrag()
    {
        if (isDragging)
        {
            transform.localPosition = spriteDragStartPosition + (Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseDragStartPosition);
        }
    }

private void OnMouseUp ()
    {
        isDragging = false;
        dragEndedCallback(this);
    }
}
