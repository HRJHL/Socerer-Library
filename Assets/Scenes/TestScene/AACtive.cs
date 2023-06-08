using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AACtive : MonoBehaviour
{
    GameObject END;
    GameObject Puze;
    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.name == "333(Clone)"){
            Variable.LL = Variable.LL + "3";
        }
        if(collider.gameObject.name == "222(Clone)"){
            Variable.LL = Variable.LL + "2";
            }
    }

    private void OnTriggerStay2D(Collider2D collider){
        if(collider.gameObject.name == "333(Clone)"){
            END = collider.transform.Find("END").gameObject;
            END.gameObject.SetActive(true);
        }
        if(collider.gameObject.name == "222(Clone)"){
            Puze = collider.transform.Find("Puze").gameObject;
            Puze.gameObject.SetActive(true);
            }
    }

    private void OnTriggerExit2D(Collider2D collider){
        if(collider.gameObject.name == "333(Clone)"){
            END = collider.transform.Find("END").gameObject;
            END.gameObject.SetActive(false);
            Variable.LL = Variable.LL.Substring(0, Variable.LL.Length-1);
        }
        if(collider.gameObject.name == "222(Clone)"){
            Puze = collider.transform.Find("Puze").gameObject;
            Puze.gameObject.SetActive(false);
            Variable.LL = Variable.LL.Substring(0, Variable.LL.Length-1);
        }
    }
}
