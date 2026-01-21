using UnityEngine;

public class HealthAudio : MonoBehaviour
{
    public void PlaySound(int value)
    {
        GetComponent<AudioSource>().Play();
    }
}
