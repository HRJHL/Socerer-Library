using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] protected Panel panel; // ����Ƽ���� �Ŵ������� �г��� �����Ű����, �г��� ���� �־�� �Ѵ�.

    public virtual void Initialize() { }

    public virtual void OpenPanel()
    {
        panel.Open();
    }

    public virtual void ClosePanel()
    {
        panel.Close();
    }
}