using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public GameObject targetPosition;
    Vector3 speed = Vector3.zero;
    void Update()
    {
     transform.position = Vector3.SmoothDamp(transform.position,targetPosition.transform.position,ref speed, 0.01f);
    }

}
