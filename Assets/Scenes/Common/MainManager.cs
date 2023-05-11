using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager instance = null;

    private void Awake()
    {
        instance = this;
    }

    private IEnumerator Start()
    {
        // 각 매니저들 인스턴스 초기화 대기
        //while (.instance == null || .instance == null) yield return null;

        Initialize();
    } // 이렇게 번거롭게 하는 이유는 start에서 인스턴스를 넣어주는 이유는 그 전에는 제대로 주소가 들어가지 않을 수도 있기 때문이다.

    private void Initialize()
    {
        //.instance.Initialize();

        // .instance.OpenPanel();
    }
}
