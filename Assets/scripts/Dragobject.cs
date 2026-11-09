
using UnityEngine;
using UnityEngine.InputSystem;  

public class Dragobject : MonoBehaviour {
private bool isDragging = false;
private Vector3 offset;

void Update ()
    {
        if (isDragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }


private void OnMouseDown ()
    {
       offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
       isDragging = true;
        
    }

private void OnMouseUp ()
    {
        isDragging = false;
    }
}
