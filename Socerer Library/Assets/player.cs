using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    int playerSpeed = 5;
    SpriteRenderer spriter;
    private void Start()
    {
        spriter = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove(){
        
        transform.Translate(new Vector3(-playerSpeed*Time.deltaTime/3, 0, 0));
    
    }


}

