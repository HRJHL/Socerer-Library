using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move_St1R : MonoBehaviour
{
    public void OnClick(){
        GameObject END = GameObject.Find("END");
        if(END.activeSelf == true){
            SceneManager.LoadScene("Stage111");
        }
        else{
            print("문장 작성");
        }
    }

}
