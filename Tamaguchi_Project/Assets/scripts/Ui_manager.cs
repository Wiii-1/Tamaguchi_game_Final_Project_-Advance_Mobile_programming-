using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Fridge")]
    [SerializeField] private GameObject fridgePanel;

    [Header("Main UI")]
    [SerializeField] private GameObject fridgeButton;

    [Header("References")]
    [SerializeField] private petStats petStats;


    private bool uiLocked = false;

    private void Start()
    {
        CloseFridge();
    }

    private void Update()
    {
        if (petStats != null && petStats.isDead && !uiLocked)
        {
            DisableAllUI();
        }
    }

    public void OpenFridge()
    {
        if (uiLocked) return;

        if (fridgePanel != null) fridgePanel.SetActive(true);
        if (fridgeButton != null) fridgeButton.SetActive(false);
    }

    public void CloseFridge()
    {
        if (uiLocked) return;

        if (fridgePanel != null) fridgePanel.SetActive(false);
        if (fridgeButton != null) fridgeButton.SetActive(true);
    }

    private void DisableAllUI()
    {
        uiLocked = true;

        if (fridgePanel != null) fridgePanel.SetActive(false);
    }
}