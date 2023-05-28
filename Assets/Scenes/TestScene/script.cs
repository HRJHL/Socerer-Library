using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collider){
        if(collider.gameObject.name == "Puze"){
            transform.position = collider.gameObject.transform.position;
            
        }
    }
}
