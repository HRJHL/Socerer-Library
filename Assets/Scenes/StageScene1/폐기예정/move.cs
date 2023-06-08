using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    int playerSpeed = 5;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove(){
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-playerSpeed*Time.deltaTime*3, 0, 0));
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(playerSpeed*Time.deltaTime*3, 0, 0));
             
        }
        if(Input.GetKey(KeyCode.S)){
             transform.Translate(new Vector3(0, -playerSpeed*Time.deltaTime*3, 0));
         }
         if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, playerSpeed*Time.deltaTime*3, 0));
        }

    }


}