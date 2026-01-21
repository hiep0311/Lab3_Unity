using UnityEngine;

public class MouseRotation2D : MonoBehaviour
{
    public float currentAngle;

    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        mouse.z = 10;
        Vector3 worldMouse = Camera.main.ScreenToWorldPoint(mouse);

        Vector2 dir = worldMouse - transform.position;

        currentAngle = Vector2.SignedAngle(Vector2.up, dir);
        transform.rotation = Quaternion.Euler(0, 0, currentAngle);
    }
}
