using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class LoadSaveData : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI _text;
    //[SerializeField] private SaveData m_save2;
    //[SerializeField] private SaveData m_save3;
    

    public void OnApplicationQuit() // saving
    {
        SaveData data = new SaveData();
        data.highScore = "";
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath + "/SaveData.json", json);
        PlayerPrefs.SetString("HighScore", "True");

    }

    private void Awake()
    {
       
        //if(PlayerPrefs.HasKey("HighScore"))
        if(File.Exists(Application.dataPath + "/SaveData.json"))
        {
            string json = File.ReadAllText(Application.dataPath + "/SaveData.json");
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            _text.text = data.highScore;
            /*
            int x = 10;
            x.ToString();
            

            int y = int.Parse(data.highScore);
            */
        }

        
    }
}
