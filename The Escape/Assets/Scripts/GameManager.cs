using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameOver = false;

    public void EndGame()
    {
        if(gameOver == false)
        {
            gameOver = true;
            Time.timeScale = 0.1f;
            Debug.Log("Game Over!");
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void RestartTime()
    {
        Time.timeScale = 1;
    }
}
