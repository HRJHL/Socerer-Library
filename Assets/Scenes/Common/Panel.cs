using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    [SerializeField] private GameObject panelObject; // � ���� �Ѱ� �� ������ ���ϴ� �����̴�-*

    public virtual void Initialize() { } // ���� �Լ� _ �ٸ� ���� �޾��� �� �ڱ� ���ϴ� ������� ���� �����ϵ���

    public virtual void Open() // �̰� �����ؼ� ����Ϸ��� override�ؾ� ��-*
    {
        panelObject.SetActive(true);
    }

    public virtual void Close()
    {
        panelObject.SetActive(false);
    }
}