using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move_Main : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick(){
        SceneManager.LoadScene("Main_Home");
        Debug.Log("Bootn Click");
    }

}
