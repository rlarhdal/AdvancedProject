using System;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("# Top")]
    public TextMeshProUGUI happinessText;
    public TextMeshProUGUI goldText;

    [Header("# Bottom")]
    public Image bottomPanel;
    public Animator animator;

    private void Start()
    {
        Init();
    }

    public void Init()
    {
        happinessText.text = $"{ManagementManager.Instance.GameManager.happiness}%";
        goldText.text = $"{ManagementManager.Instance.GameManager.gold}G";
    }

    public void UpdateGold()
    {
        goldText.text = $"{ManagementManager.Instance.GameManager.gold}G";
    }

    public void OnMenu()
    {
        bool isOpen = animator.GetBool("isOpen") ? true : false;
        animator.SetBool("isOpen", !isOpen);
    }
}
