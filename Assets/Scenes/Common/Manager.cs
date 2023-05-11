using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] protected Panel panel; // 유니티에서 매니저에서 패널을 연결시키려면, 패널이 열려 있어야 한다.

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