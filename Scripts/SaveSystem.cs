using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

public class SaveSystem : MonoBehaviour
{
    public void SaveClicks(int clicks)
    {
        SaveData data = new SaveData();

        SaveData.clicks = clicks;

        string json = JsonConvert.SerializeObject(data);

        File.WriteAllText(Application.persistentDataPath + "/saveData.json", json);
    }

    public void SaveTime(float bectTime)
    {
        SaveData data = new SaveData();

        SaveData.bestTime = bectTime;

        string json = JsonConvert.SerializeObject(data);

        File.WriteAllText(Application.persistentDataPath + "/saveData.json", json);
    }

    public void SaveAll()
    {
        Dictionary<string, object> data = new Dictionary<string, object>();

        data["clicks"] = SaveData.clicks;
        data["bestTime"] = SaveData.bestTime;

        string json = JsonConvert.SerializeObject(data);

        File.WriteAllText(Application.persistentDataPath + "/saveData.json", json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/saveData.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);

            Dictionary<string, object> data = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

            SaveData.clicks = (int)(long)data["clicks"];
            SaveData.bestTime = (float)(double)data["bestTime"];
        }
        else
        {
            Debug.Log("Save data not found!");
        }
    }
}
