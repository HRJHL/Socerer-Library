using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public GameObject targetPosition;
    void Start()
    {
     transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPosition.transform.position, 0.00000001f);
    }
    

}
