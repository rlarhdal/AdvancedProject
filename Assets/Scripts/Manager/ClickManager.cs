using System;
using System.Collections;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public GameObject spawnScore;
    public Transform parent;

    private void Start()
    {
        InvokeRepeating("AutoClick", 0, ManagementManager.Instance.GameManager.timer);
    }

    private void AutoClick()
    {
        ManagementManager.Instance.GameManager.gold += ManagementManager.Instance.GameManager.autoGold;
        SpawnScore();
        ManagementManager.Instance.GameManager.uiManager.UpdateGold();
    }

    public void SpawnScore()
    {
        GameObject spawnObject = Instantiate(spawnScore, parent);
        spawnObject.transform.position = transform.position;
    }

    public void OnClick()
    {
        ManagementManager.Instance.GameManager.gold++;
        ManagementManager.Instance.GameManager.uiManager.UpdateGold();
        //SpawnScore();
    }
}
