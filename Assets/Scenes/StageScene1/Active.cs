using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{
    GameObject END;
    GameObject up;
    GameObject down;
    GameObject left;
    GameObject right;

    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.name == "Up(Clone)"){
            Variable.LL = Variable.LL + "2";
            }
        if(collider.gameObject.name == "Down(Clone)"){
            Variable.LL = Variable.LL + "3";
            }
        if(collider.gameObject.name == "Left(Clone)"){
            Variable.LL = Variable.LL + "4";
            }
        if(collider.gameObject.name == "Right(Clone)"){
            Variable.LL = Variable.LL + "5";
            }
    }

    private void OnTriggerStay2D(Collider2D collider){
        if(collider.gameObject.name == "End(Clone)"){
            END = collider.transform.Find("END").gameObject;
            END.gameObject.SetActive(true);
        }

        if(collider.gameObject.name == "Up(Clone)"){
            up = collider.transform.Find("up").gameObject;
            up.gameObject.SetActive(true);
            }

        if(collider.gameObject.name == "Down(Clone)"){
            down = collider.transform.Find("down").gameObject;
            down.gameObject.SetActive(true);
            }
        
        if(collider.gameObject.name == "Left(Clone)"){
            left = collider.transform.Find("left").gameObject;
            left.gameObject.SetActive(true);
            }
        
        if(collider.gameObject.name == "Right(Clone)"){
            right = collider.transform.Find("right").gameObject;
            right.gameObject.SetActive(true);
            }
    }

    private void OnTriggerExit2D(Collider2D collider){
        if(collider.gameObject.name == "End(Clone)"){
            END = collider.transform.Find("END").gameObject;
            END.gameObject.SetActive(false);
        }
        
        if(collider.gameObject.name == "Up(Clone)"){
            up = collider.transform.Find("up").gameObject;
            up.gameObject.SetActive(false);
            Variable.LL = Variable.LL.Substring(0, Variable.LL.Length-1);
        }

        if(collider.gameObject.name == "Down(Clone)"){
            down = collider.transform.Find("down").gameObject;
            down.gameObject.SetActive(false);
            Variable.LL = Variable.LL.Substring(0, Variable.LL.Length-1);
        }

        if(collider.gameObject.name == "Left(Clone)"){
            left = collider.transform.Find("left").gameObject;
            left.gameObject.SetActive(false);
            Variable.LL = Variable.LL.Substring(0, Variable.LL.Length-1);
        }

        if(collider.gameObject.name == "Right(Clone)"){
            right = collider.transform.Find("right").gameObject;
            right.gameObject.SetActive(false);
            Variable.LL = Variable.LL.Substring(0, Variable.LL.Length-1);
        }
    }
}
