using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragBACK : MonoBehaviour
{
   float distance = 10;

    void OnMouseDrag()
    {
        
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, 
Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        objPosition.y = 0;
        transform.position = objPosition;
    }

   
}

