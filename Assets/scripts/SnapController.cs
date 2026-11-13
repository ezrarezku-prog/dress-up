using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SnapController : MonoBehaviour
{
   
   public List<Transform> snapPoints;
   public List<Dragobject> draggableObjects;
   public float snapRange = 0.5f;
    void Start()
    {
        foreach(Dragobject draggable in draggableObjects)
        {
            draggable.dragEndedCallback = OnDragEnded;
        }
    }

    private void OnDragEnded(Dragobject draggable)
    {
        float closestDistance = -1;
        Transform closestSnapPoint = null;

        foreach (Transform snapPoint in snapPoints)
        {
            float currentDistance = Vector2.Distance(draggable.transform.position, snapPoint.localPosition);
            if (closestSnapPoint == null || currentDistance < closestDistance)
            {
                closestSnapPoint = snapPoint;
                closestDistance = currentDistance;
            }
        }

        if (closestSnapPoint != null && closestDistance <= snapRange)
        {
            draggable.transform.localPosition = closestSnapPoint.localPosition;
        }
    }
}
