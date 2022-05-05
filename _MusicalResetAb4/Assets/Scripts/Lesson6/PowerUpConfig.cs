using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MusicalRunes;

[System.Serializable]
[CreateAssetMenu(fileName = "New PowerUp Config", menuName =  "Configs/PowerUp")]


public class PowerUpConfig : ScriptableObject
{
    public PowerUpType m_powerUpType;
    // public string m_powerUpName;
    // [TextArea] public string m_description;
    public Sprite m_icon;
    public bool m_Upgradable;

    public string m_powerUpNameID;
    public string m_descriptionID;

    public string m_powerUpName => Localization.s_currentLocalizationTable[m_powerUpNameID];
    public string m_description => Localization.s_currentLocalizationTable[m_descriptionID];
}
