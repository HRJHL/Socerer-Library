using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetmove : MonoBehaviour
{
    void Start()
    {
        int b = 0;
        string a = Variable.LL;
        foreach(char c in a){
            if(c=='2'){
                transform.position = transform.position + new Vector3(3,0,0);
                print(b);
                b++;
            }
            if(c=='3'){
                transform.position = transform.position + new Vector3(0,3,0);
                print(b);
            }
        }
    }

}
