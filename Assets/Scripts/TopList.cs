using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TopList : MonoBehaviour
{
    public static TopList Instance;
    public string YourNickName;
    public int YourScore;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadBestScore();
    }

    [System.Serializable]
    class SaveData
    {
        public string NickName;
        public int Score;
    }

    public void SaveBestScore()
    {
        SaveData data = new SaveData();
        data.NickName = YourNickName;
        data.Score = YourScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/BestScore.json", json);
    }

    public void LoadBestScore()
    {
        string path = Application.persistentDataPath + "/BestScore.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            YourNickName = data.NickName;
            YourScore = data.Score;
        }
    }

}
