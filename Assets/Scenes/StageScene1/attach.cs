using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attach : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collider){

        if(collider.gameObject.name == "ST"){
            transform.position = collider.gameObject.transform.position;
        }

        if(collider.gameObject.name == "up"){
            transform.position = collider.gameObject.transform.position;
        }

        if(collider.gameObject.name == "down"){
            transform.position = collider.gameObject.transform.position;
        }

        if(collider.gameObject.name == "left"){
            transform.position = collider.gameObject.transform.position;
        }

        if(collider.gameObject.name == "right"){
            transform.position = collider.gameObject.transform.position;
        }
    }
}
