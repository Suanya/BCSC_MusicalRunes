using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using MusicalRunes;

public class ShowHintPowerUp : PowerUp
{
    [SerializeField] private Image[] m_btnImgs;
    [SerializeField] private RuneSelector m_RSScript;


    public override void OnPowerUpClick()
    {
        if (m_isAvailable)
        {
            base.OnPowerUpClick();
            m_btnImgs[m_RSScript.m_currentIndex].color = Color.green;
        }
    }
}
