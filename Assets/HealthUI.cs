using UnityEngine;
using TMPro;

public class HealthUI : MonoBehaviour
{
    public TextMeshProUGUI healthText;

    public void UpdateUI(int health)
    {
        healthText.text = "Health: " + health;
    }
}
