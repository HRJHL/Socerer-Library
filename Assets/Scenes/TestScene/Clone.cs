using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{
    private Transform BPoint;
    public GameObject BluckPrefab;
    // Start is called before the first frame update
    void Start()
    {
        BPoint = this.transform.Find("BPoint");
    }

    // Update is called once per frame
    public void OnClick(){
             var cbluck = Instantiate<GameObject>(this.BluckPrefab);
            cbluck.transform.position = this.BPoint.position;
    }
}
