using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
   float distance = 10;
   GameObject BLLK;

    void OnMouseDrag()
    {
        
        BLLK = GameObject.Find("BLLK");
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, 
Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        if(objPosition.y > 4){
            objPosition.y = 4;
        }
        if(objPosition.y < -4){
            objPosition.y = -4;
        }
        if(objPosition.x > 9){
            objPosition.x = 8;
        }
        if(objPosition.x < BLLK.transform.position.x){
            objPosition.x = BLLK.transform.position.x + 1;
        }
        transform.position = objPosition;
    }

   
}

