using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move_Opt : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick(){
        SceneManager.LoadScene("Option");
        Debug.Log("Bootn Click");
    }

}
