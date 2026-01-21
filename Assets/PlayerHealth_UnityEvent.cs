using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth_UnityEvent : MonoBehaviour
{
    public int health = 100;

    public UnityEvent<int> OnHealthChanged;
    public UnityEvent OnGameOver;

    bool isDead = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (isDead) return;   // ⬅️ CHỈ return sau khi GameOver đã chạy

            health -= 10;
            Debug.Log("Health: " + health);

            OnHealthChanged.Invoke(health);

            if (health <= 0 && !isDead)
            {
                isDead = true;
                Debug.Log("GAME OVER INVOKED");
                OnGameOver.Invoke();   // ✅ CHẮC CHẮN CHẠY
            }
        }
    }
}
