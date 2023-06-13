using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    float playerSpeed = 1.25f;
    string a;
    float timer;
    int i;
     void Start()
    {
        a = Variable.LL;
        i =0;
        timer = 30;
        print(a);
        foreach(char c in a){
            print(a[i]);
            if(a[i]=='2'){
                Invoke("up", i*2+1);
            }
            if(a[i]=='3'){
                Invoke("down", i*2+1);
            }
            if(a[i]=='4'){
                Invoke("left", i*2+1);
            }
            if(a[i]=='5'){
                Invoke("right", i*2+1);
            }
            i++;
        }
            }


    void Update()
    {
        timer += Time.deltaTime;
        if(timer < 2.5 && timer > 0){
            transform.Translate(new Vector3(0, playerSpeed*Time.deltaTime, 0));
        }
        else{
            if(timer>30){
                timer = 100;
            }
        }
        

        if(timer > 4 && timer < 6.5){
            transform.Translate(new Vector3(0, -playerSpeed*Time.deltaTime, 0));
        }
        else{
            if(timer>30){
                timer = 110;
            }
        }

        if(timer > 8 && timer < 10){
            transform.Translate(new Vector3(playerSpeed*Time.deltaTime, 0, 0));
        }
        else{
            if(timer>30){
                timer = 110;
            }
        }

        if(timer > 12 && timer < 14){
            transform.Translate(new Vector3(-playerSpeed*Time.deltaTime, 0, 0));
        }
        else{
            if(timer>30){
                timer = 111;
            }
        }
}
void up(){
    timer = 0;
}
void down(){
    timer = 4;
}
void left(){
    timer = 8;
}
void right(){
    timer = 12;
}

}