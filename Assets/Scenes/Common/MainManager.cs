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
        // �� �Ŵ����� �ν��Ͻ� �ʱ�ȭ ���
        //while (.instance == null || .instance == null) yield return null;

        Initialize();
    } // �̷��� ���ŷӰ� �ϴ� ������ start���� �ν��Ͻ��� �־��ִ� ������ �� ������ ����� �ּҰ� ���� ���� ���� �ֱ� �����̴�.

    private void Initialize()
    {
        //.instance.Initialize();

        // .instance.OpenPanel();
    }
}
