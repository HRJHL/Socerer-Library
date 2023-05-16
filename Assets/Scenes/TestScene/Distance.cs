using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    GameObject dist1;
    GameObject dist2;
    GameObject dist3;
    private float Dist1;
    private float Dist2;
    private float Dist3;

    void Update(){
    dist1 = GameObject.Find("111");
    dist2 = GameObject.Find("222");
    dist3 = GameObject.Find("333");
        Dist1 = Vector3.Distance(dist1.transform.position, dist2.transform.position);
        Dist2 = Vector3.Distance(dist1.transform.position, dist3.transform.position);
        Dist3 = Vector3.Distance(dist2.transform.position, dist3.transform.position);
    }

    void LateUpdate()
    {
        if(Dist1 <4){
            dist2.transform.position = dist1.transform.position+new Vector3(0,-3,0);
        }
        if(Dist2 <4){
            dist3.transform.position = dist1.transform.position+new Vector3(0,-3,0);
        }
        if(Dist3 <4){
            dist3.transform.position = dist2.transform.position+new Vector3(0,-3,0);
        }
        print("Dist: " + Dist1 );
        print("Dist: " + Dist2 );
        print("Dist: " + Dist3 );
    }

}