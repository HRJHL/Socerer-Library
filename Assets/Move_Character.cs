using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move_Character : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick(){
        SceneManager.LoadScene("Character");
        Debug.Log("Bootn Click");
    }

}
