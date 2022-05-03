using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBehaviour : MonoBehaviour
{
    private bool m_gameIsActive = true;

    private void Update()
    {
        if (m_gameIsActive == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += transform.forward;
            }
        }
    }
    private void LateUpdate()
    {
        if (m_gameIsActive == false)
        {
            return;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward;
        }
    }

    private string m_triggerAxisName = "XRI_Left_Grip";
    private bool m_triggerPressed = false;

    private void FixedUpdate()
    {
        //StartCoroutine();
        if(Input.GetAxis(m_triggerAxisName) > 0.8f && m_triggerPressed == false)
        {
            m_triggerPressed = true;
            //Grab
        }
        else if(Input.GetAxis(m_triggerAxisName) < 0.8f && m_triggerPressed == true)
        {
            m_triggerPressed = false;
            //release
        }
    }


    List<Renderer> m_rends = new List<Renderer>();
    Renderer[] m_rendArray;

    private void Awake()
    {
        m_rendArray = GetComponentsInChildren<Renderer>();
        var rend = m_rends[0];

        foreach(var r in m_rendArray)
        {
            r.enabled = false;
        }

        for(int i = 0; i < m_rends.Count; i++)
        {

        }

        while (true)
        {
            //do something
        }
    }
}
