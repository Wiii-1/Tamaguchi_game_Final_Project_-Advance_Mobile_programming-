using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Open This")]
    [SerializeField] private GameObject fridgePanel;

    [Header("Close These")]
    [SerializeField] private GameObject coinPanel;
    [SerializeField] private GameObject fridgeButton;
    [SerializeField] private GameObject marketButton;

    private void Start()
    {
        CloseFridge();
    }

    public void OpenFridge()
    {
        SetUIState(true);
    }

    public void CloseFridge()
    {
        SetUIState(false);
    }

    private void SetUIState(bool fridgeOpen)
    {
        if (fridgePanel != null)
            fridgePanel.SetActive(fridgeOpen);

        if (coinPanel != null)
            coinPanel.SetActive(!fridgeOpen);

        if (fridgeButton != null)
            fridgeButton.SetActive(!fridgeOpen);

        if (marketButton != null)
            marketButton.SetActive(!fridgeOpen);
    }
}