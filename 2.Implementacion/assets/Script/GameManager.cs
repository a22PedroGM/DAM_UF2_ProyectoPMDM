using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Reanudar();
            }
            else
            {
                Pausar();
            }
        }
    }

    public void Reanudar()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // Reanudar el tiempo en el juego
        GameIsPaused = false;
    }

    void Pausar()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // Pausar el tiempo en el juego
        GameIsPaused = true;
    }
}
