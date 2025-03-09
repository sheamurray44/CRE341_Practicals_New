using UnityEngine;
using TMPro;
using StarterAssets;

public class UI_Updater : MonoBehaviour
{
    public TextMeshProUGUI itemsText;
    public FirstPersonController firstPersonController;

    private void Start()
    {
        itemsText.text = $"Weapon Pieces Collected: {firstPersonController.collectedItems}/3";
    }

    private void Update()
    {
        itemsText.text = $"Weapon Pieces Collected: {firstPersonController.collectedItems}/3";
    }
}
