using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestorEscenas : MonoBehaviour
{
    public void CargarJuego()
    {
        SceneManager.LoadScene("Juego1"); 
    }

    public void CargarMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void CargarGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void CargarVictoria()
    {
        SceneManager.LoadScene("Victoria");
    }

    public void SalirJuego()
    {
        Application.Quit(); 
    }
}
