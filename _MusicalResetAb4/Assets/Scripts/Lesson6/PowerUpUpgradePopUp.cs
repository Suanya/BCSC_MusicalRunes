using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MusicalRunes
{
    public class PowerUpUpgradePopUp : MonoBehaviour
    {
        public Image m_btnImage;
        public Button m_btn;
        public PowerUpConfig m_powerUpConfig;


        public void Start()
        {
            Setup(m_powerUpConfig);
        }

        public void Setup(PowerUpConfig powerUpConfig)
        {
            m_btnImage.sprite = powerUpConfig.m_icon;
            gameObject.name = powerUpConfig.m_powerUpName;
            m_btn.interactable = powerUpConfig.m_Upgradable;
        }
    }
}


