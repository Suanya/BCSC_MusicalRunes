using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public abstract class PowerUp : MonoBehaviour
{

    [SerializeField] private Image m_powerUpBtn;

    [SerializeField] private int m_coolDownDuration = 3;
    private float m_currentCoolDown;

    protected bool m_isAvailable => m_currentCoolDown <= 0;

    private void Update()
    {
        if(m_currentCoolDown >= 0)
        {
            m_currentCoolDown -= Time.deltaTime;
            m_powerUpBtn.fillAmount = 1 - m_currentCoolDown / m_coolDownDuration;
        }
    }

    public virtual void OnPowerUpClick() // child powerUp will use this function, override and add functionality
    {
        if (!m_isAvailable) return;

        m_currentCoolDown = m_coolDownDuration;
    }
}
