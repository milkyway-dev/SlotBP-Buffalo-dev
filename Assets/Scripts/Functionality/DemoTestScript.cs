using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoTestScript : MonoBehaviour
{
    [SerializeField]
    private Transform m_ParentSlotsHolder;
    [SerializeField]
    private int m_ChildIndex = 10;
    private int m_Temp;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Temp = m_ChildIndex;
            m_ParentSlotsHolder.GetChild(m_ChildIndex).SetAsLastSibling();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_ParentSlotsHolder.GetChild(m_ParentSlotsHolder.childCount - 1).SetSiblingIndex(m_Temp);
        }
    }
}
