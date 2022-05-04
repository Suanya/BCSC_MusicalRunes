using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHintPowerUp : PowerUp
{
    [SerializeField] private Image[] m_btnImgs;
    [SerializeField] private RuneSelectorCombination m_RSCScript;

   

    public override void OnPowerUpClick()
    {
        base.OnPowerUpClick();
        m_btnImgs[m_RSCScript.m_currentIndex + 1].color = Color.green;
    }
}
