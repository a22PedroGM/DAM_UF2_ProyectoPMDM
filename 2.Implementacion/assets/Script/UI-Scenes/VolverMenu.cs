using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverMenu : MonoBehaviour
{
   public string escena = "MenuScene";

    public void VolverAlMenu()
    {
        // Cargar la escena del menú
        SceneManager.LoadScene(escena);
    }
}
