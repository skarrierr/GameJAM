using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Buttons : MonoBehaviour
{
  public void RestartButton()
    {
        SceneManager.LoadScene("juego");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
