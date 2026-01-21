using UnityEngine;

public class GameOverHandler : MonoBehaviour
{
    public void GameOver()
    {
        Debug.Log("GAME OVER");
        Time.timeScale = 0;
    }
}
