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


/*
 * 
 * [SerializeField] Renderer m_rend;

    public static float s_spectrumValue;
    private float[] m_audioSpectrum;
    // Use this for initialization
    void Awake()
    {
        m_audioSpectrum = new float[128];
    }

    // Update is called once per frame
    void Update()
    {
        AudioListener.GetSpectrumData(m_audioSpectrum, 0, FFTWindow.Hamming);

        if(m_audioSpectrum != null && m_audioSpectrum.Length > 0)
        {
            s_spectrumValue = m_audioSpectrum[0] * 100;

      */
