using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    public Transform target;
    public bool smoothRotation = true;
    public float rotateSpeed = 5f;

    void Update()
    {
        if (target == null) return;

        Vector3 dir = target.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion targetRot = Quaternion.Euler(0, 0, angle);

        if (smoothRotation)
            transform.rotation = Quaternion.Lerp(
                transform.rotation, targetRot, rotateSpeed * Time.deltaTime);
        else
            transform.rotation = targetRot;
    }
}
