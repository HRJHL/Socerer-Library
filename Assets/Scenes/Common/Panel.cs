using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    [SerializeField] private GameObject panelObject; // 어떤 것을 켜고 끌 것인지 정하는 변수이다-*

    public virtual void Initialize() { } // 가상 함수 _ 다른 데서 받았을 때 자기 원하는 모양으로 변동 가능하도록

    public virtual void Open() // 이걸 변경해서 사용하려면 override해야 함-*
    {
        panelObject.SetActive(true);
    }

    public virtual void Close()
    {
        panelObject.SetActive(false);
    }
}