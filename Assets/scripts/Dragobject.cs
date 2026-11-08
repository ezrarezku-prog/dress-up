
using UnityEngine;

public class Dragobject : MonoBehaviour
{
   private Vector3 mouseoffset;

   private Vector3 GetMousePosition()
     {
          Vector3 mousePoint = Input.mousePosition;
          mousePoint.z = Camera.main.WorldToScreenPoint(transform.position).z;
          return Camera.main.ScreenToWorldPoint(mousePoint);
     }


   void OnMouseDown()
     {
          mouseoffset = transform.position - GetMousePosition();
     }
     
    void OnMouseDrag()
    {
        transform.position = GetMousePosition() + mouseoffset;
    }
}
