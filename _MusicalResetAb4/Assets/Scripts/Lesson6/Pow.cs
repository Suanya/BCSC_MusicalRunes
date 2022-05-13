using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MusicalRunes;

public class Pow : MonoBehaviour
{
    public PowerUpConfig m_powerUp;

    public void Start()
    {
        Debug.Log(m_powerUp.m_powerUpName);
        Debug.Log(m_powerUp.m_description);
         
        if(m_powerUp.m_powerUpType == PowerUpType.hint)
        {
            Debug.Log("true");
        }
    }

}
