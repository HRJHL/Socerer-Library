using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
  float rightMax = 5.0f;
    float leftMax = -5.0f;
    float currentPosition;
    float direction = 3.0f;
    void Start()
    {
        currentPosition = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition += Time.deltaTime*direction;
        if(currentPosition >= rightMax){
            direction *= -1;
            currentPosition = rightMax;
        }
        else if(currentPosition <= leftMax){
            direction *= -1;
            currentPosition = leftMax;
        }

        transform.position = new Vector3(currentPosition,0 ,0);
    }


}

