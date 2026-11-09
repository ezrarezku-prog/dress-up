using UnityEngine;
//script that moves TOP clothes
public class DragSnapRaycast : MonoBehaviour
{
    
    private Transform dragging = null;
    private Vector3 offset;
    

void Update()
    { 
        
    if (Input.GetMouseButtonDown(0))
        {RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero,
                                              float.PositiveInfinity, LayerMask.GetMask("top") );
                                            //positiveinfinity je na to jak daleko dosahne raycast - jak jsou velky canvas  
            
            if (hit)
            {   
            dragging = hit.transform;
            offset = dragging.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);

            
            }
        }
    else if (Input.GetMouseButtonUp(0))
    {
        if (dragging != null)
        {  
            dragging = null;}
            
     }
    if (dragging != null)
        {
            dragging.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }

}
