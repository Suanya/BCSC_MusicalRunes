using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReplayPowerUp : PowerUp
{
    [[SerializeField] private Image[] m_btnImgs;
    [SerializeField] private RuneSelector m_RSCScript;
    [SerializeField] private int m_minIndex = 0;


    public override void OnPowerUpClick()
    {
        if (m_isAvailable && m_RSCScript.m_currentIndex > m_minIndex)
        {
            base.OnPowerUpClick();

            m_RSCScript.m_currentIndex = 0;

            foreach (Image img in m_btnImgs)
            {
                img.color = Color.white;
            }
        }
    }
}
