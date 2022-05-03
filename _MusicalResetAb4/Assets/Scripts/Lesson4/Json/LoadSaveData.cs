using System.IO;
using UnityEngine;

/// <summary>
/// whole script not needed
/// </summary>

public class LoadSaveData : MonoBehaviour
{
    private object m_currentScore;

    /*
NiceForAR -> struct/wrapper -> differentModels differentMoments
[SerializeField] private SaveData m_save1;
[SerializeField] private SaveData m_save2;
[SerializeField] private SaveData m_save3;
*/


    // saving
    /*
    public void OnApplicationQuit()
    {
        SaveData data = new SaveData();
        data.highScore = "20";
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath + "/SaveData.json", json);
        PlayerPrefs.SetString("HighScore", "True");
    }
    */

    /*
    // loading
    private void Awake()
    {
        
        if (File.Exists(Application.dataPath + "/SaveData.json"))
        {
            string json = File.ReadAllText(Application.dataPath + "/SaveData.json");
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            int x = 10;
            x.ToString();

            int y = int.Parse(data.highScore);


        }

        

        /*
        // Alternative PlayerPrefs
        if (PlayerPrefs.HasKey("HighScore"))
        {
            string json = File.ReadAllText(Application.dataPath + "/SaveData.json");
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            
            int x = 10;
            x.ToString();

            int y = int.Parse(data.highScore);
        */
        
    }







