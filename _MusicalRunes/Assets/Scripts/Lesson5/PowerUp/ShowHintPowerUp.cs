using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHintPowerUp : PowerUp
{
    [SerializeField] private Image[] m_btnImgs;
    [SerializeField] private RuneSelector m_RSScript;

    /*
    private int[] m_correctSequence;

    private void Awake()
    {
        m_correctSequence = m_RSScript.m_currentRuneSquence;
    }
    */

    public override void OnPowerUpClick()
    {
        if (m_isAvailable)
        {
            base.OnPowerUpClick();

            m_btnImgs[m_RSScript.m_currentIndex].color = Color.green;
        }
        
    }
}


