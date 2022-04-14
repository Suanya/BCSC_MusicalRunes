using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestEvents : MonoBehaviour
{
    
    [SerializeField] private UnityEvent m_click;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            m_click.Invoke();
        }
    }

    public void TestCall(int i)
    {
        Debug.Log($"Eli is #{i}!");
    }

}
