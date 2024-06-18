using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int gold;
    public int happiness;
    public int timer;
    public int autoGold;

    public UIManager uiManager;
    public DataManager dataManager;
    public ClickManager clickManager;
    public PlayerData playerData;

    private void Awake()
    {
        ManagementManager.Instance.GameManager = this;

        uiManager = GetComponent<UIManager>();
        dataManager = GetComponent<DataManager>();
        clickManager = GetComponent<ClickManager>();
    }

    private void Start()
    {
        InitGame();
    }

    private void InitGame()
    {
        ManagementManager.Instance.GameManager.uiManager.Init();
    }
}
