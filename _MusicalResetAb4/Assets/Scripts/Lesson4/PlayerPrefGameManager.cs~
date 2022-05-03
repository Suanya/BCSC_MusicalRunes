using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPrefGameManager : MonoBehaviour
{
    public static PlayerPrefGameManager s_instance;

    [SerializeField] private TextMeshProUGUI m_highScoreText;
    [SerializeField] private TextMeshProUGUI m_currentScoreText;

    private int m_highScore;
    private int m_currentScore;
    private string m_scoreKey = "HighScore";

    public void AddScore(int points)
    {
        m_currentScore += points;
        m_currentScoreText.text = m_currentScore.ToString();

        if(m_currentScore > m_highScore)
        {
            m_highScore = m_currentScore;
            m_highScoreText.text = m_highScore.ToString();
        }
    }

    
    private void Awake()
    {
        if (PlayerPrefs.HasKey(m_scoreKey))
        {
            m_highScore = PlayerPrefs.GetInt(m_scoreKey); // value to get
            m_highScoreText.text = m_highScore.ToString();
        }      
    }

    private void OnApplicationQuit()
    {
        if(m_currentScore > m_highScore)
        {
            PlayerPrefs.SetInt(m_scoreKey, m_currentScore);
        }
    }
}
