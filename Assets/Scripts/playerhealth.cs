using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class JugadorVida : MonoBehaviour
{
    public int vidaMaxima = 100;
    public int vidaActual;
    public Slider barraVida;

    void Start()
    {
        vidaActual = vidaMaxima;

        if (barraVida != null)
        {
            barraVida.maxValue = vidaMaxima;
            barraVida.value = vidaActual;
        }
    }
    
    public void RecibirDaño(int daño)
    {
        vidaActual -= daño;
        if (vidaActual < 0)
        {
            vidaActual = 0;
        }
       
        if (barraVida != null)
        {
            barraVida.value = vidaActual;
        }
        
        if (vidaActual <= 0)
        {
            Morir();
        }
    }

    void Morir()
    {
        SceneManager.LoadScene("GameOver");
    }
}
