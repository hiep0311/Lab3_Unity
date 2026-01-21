using TMPro;
using UnityEngine;

public class HealthUI_UnityEvent : MonoBehaviour
{
    public void UpdateHealth(int value)
    {
        GetComponent<TextMeshProUGUI>().text = "Health: " + value;
    }
}
