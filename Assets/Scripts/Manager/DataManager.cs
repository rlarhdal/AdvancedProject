using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private string dataFileName = "playerData.json";

    public void SavePlayerDataToJson()
    {
        string jsonData = JsonUtility.ToJson(ManagementManager.Instance.GameManager.playerData);
        string path = Path.Combine(Application.dataPath, dataFileName);
        byte[] data = System.Text.Encoding.UTF8.GetBytes(jsonData);
        string encodedJson = System.Convert.ToBase64String(data);
        File.WriteAllText(path, encodedJson);
    }

    public void LoadDataFromJson()
    {
        string path = Path.Combine(Application.dataPath, dataFileName);
        string jsonData = File.ReadAllText(path);
        byte[] bytes = System.Convert.FromBase64String(jsonData);
        string decodedJson = System.Text.Encoding.UTF8.GetString(bytes);
        ManagementManager.Instance.GameManager.playerData = JsonUtility.FromJson<PlayerData>(decodedJson);
    }

    // 저장할 데이터 = 게임 데이터
    public void SaveData()
    {
        ManagementManager.Instance.GameManager.gold = ManagementManager.Instance.GameManager.playerData.gold;
        ManagementManager.Instance.GameManager.happiness = ManagementManager.Instance.GameManager.playerData.happiness;

        // 파일 쓰고 저장
        SavePlayerDataToJson();
    }

    public void LoadData()
    {
        ManagementManager.Instance.GameManager.playerData.gold = ManagementManager.Instance.GameManager.gold;
        ManagementManager.Instance.GameManager.playerData.happiness = ManagementManager.Instance.GameManager.happiness;
    }
}
