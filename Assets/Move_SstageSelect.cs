using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move_SstageSelect : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick(){
        SceneManager.LoadScene("Stage_Select");
        Debug.Log("Bootn Click");
    }

}
