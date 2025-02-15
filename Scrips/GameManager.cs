using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject _gameOverCanvas;
    [SerializeField] private GameObject _pauseCanvas;

    private void Awake()
    {
        if (instance == null) instance = this;
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        _gameOverCanvas.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("MenuGame");
        Time.timeScale = 1f; // Load the Menu scene
    }

    public void PauseGame()
    {
        _pauseCanvas.gameObject.SetActive(true);  // Show the pause menu canvas
        Time.timeScale = 0f; // Pause the game
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        _pauseCanvas.gameObject.SetActive(false); // Resume the game
    }
}
