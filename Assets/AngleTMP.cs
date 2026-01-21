using UnityEngine;
using TMPro;

public class AngleTMP : MonoBehaviour
{
    public Transform turret;
    public TMP_Text angleText;

    void Update()
    {
        if (turret == null || angleText == null) return;

        float angle = turret.eulerAngles.z;
        angleText.text = "Angle: " + angle.ToString("F1");
    }
}
