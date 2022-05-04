using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager s_instance;

    [SerializeField] private TextMeshProUGUI m_highScoreText;
    [SerializeField] private TextMeshProUGUI m_currentScoreText;

    private int m_highScore;
    private int m_currentScore;
    private string m_scoreKey = "HighScore";

    public void AddScore(int points)
    {
        m_currentScore += points;
        m_currentScoreText.text = m_currentScore.ToString();

        if (m_currentScore > m_highScore)
        {
            m_highScore = m_currentScore;
            m_highScoreText.text = m_highScore.ToString();
        }
    }


    private void Awake()
    {
        if(s_instance == null)
        {
            s_instance = this;
        }
        else
        {
            Debug.LogError("tooManySingleton");
        }
       
        if (File.Exists(Application.dataPath + "/SaveData.json"))
        {
            string json = File.ReadAllText(Application.dataPath + "/SaveData.json");
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            m_highScore = int.Parse(data.highScore);
            m_highScoreText.text = m_highScore.ToString();


        }
    }

    // saving
    private void OnApplicationQuit()
    {
        if(m_currentScore >= m_highScore)
        {
            SaveData data = new SaveData();
            data.highScore = m_currentScore.ToString();
            string json = JsonUtility.ToJson(data);
            File.WriteAllText(Application.dataPath + "/SaveData.json", json);
            PlayerPrefs.SetString("HighScore", "True"); PlayerPrefs.SetInt(m_scoreKey, m_currentScore);
        }
        
        
    }
}


