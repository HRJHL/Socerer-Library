using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move_St1R : MonoBehaviour
{
    public void OnClick(){
        GameObject END = GameObject.Find("END");
        if(END.activeSelf == true){
            SceneManager.LoadScene("Stage1Run");
        }
        else{
            print("문법에 맞는 문장을 작성해 주세요");
        }
    }

}
