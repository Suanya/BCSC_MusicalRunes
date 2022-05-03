using System.IO;
using UnityEngine;

public class LoadSaveData : MonoBehaviour
{
    public void OnApplicationQuit() //saving
    {
        SaveData data = new SaveData();
        data.highScore = "10";
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath + "/SaveData.json", json);
        PlayerPrefs.SetString("HighScore", "True");
    }

    private void Awake()
    {
        if(File.Exists(Application.dataPath + "/SaveData.json"))
        //if (PlayerPrefs.HasKey("HighScore"))
        {
            string json = File.ReadAllText(Application.dataPath + "/SaveData.json");
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            int x = 10;
            x.ToString();

            int y = int.Parse(data.highScore);
        }
    }
}
