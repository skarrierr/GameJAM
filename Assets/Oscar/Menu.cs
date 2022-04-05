using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Juego");
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("MenuOscar");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
