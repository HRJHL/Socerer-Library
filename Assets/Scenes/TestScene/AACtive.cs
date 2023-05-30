using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AACtive : MonoBehaviour
{
    GameObject END;
    private void OnTriggerStay2D(Collider2D collider){
        if(collider.gameObject.name == "333(Clone)"){
            END = collider.transform.Find("END").gameObject;
            END.gameObject.SetActive(true);
        }
        if(collider.gameObject.name == "222(Clone)"){
            END = collider.transform.Find("Puze").gameObject;
            END.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collider){
        if(collider.gameObject.name == "333(Clone)"){
            END = collider.transform.Find("END").gameObject;
            END.gameObject.SetActive(false);
        }
        if(collider.gameObject.name == "222(Clone)"){
            END = collider.transform.Find("Puze").gameObject;
            END.gameObject.SetActive(false);
        }
    }
}
