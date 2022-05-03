using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MusicalRunes; // PowerUpType now available

[CreateAssetMenu(fileName = "new PowerUp Config", menuName = "Configs/Power Up")]

public class PowerUpConfig : ScriptableObject // streamlines your project
{
    public PowerUpType m_powerUpType;
    public string powerUpNames;
    [TextArea] public string m_description;
}
