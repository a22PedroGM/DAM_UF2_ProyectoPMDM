using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public string escena = "GameScene";

    public void startGame()
    {
        // Cargar la escena del juego
        SceneManager.LoadScene(escena);
    }
}
