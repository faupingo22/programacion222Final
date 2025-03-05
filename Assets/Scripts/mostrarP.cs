using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarPuntaje : MonoBehaviour
{
    public Text textoPuntaje; 

    void Start()
    {
        int puntajeFinal = PlayerPrefs.GetInt("PuntajeFinal", 0);
        textoPuntaje.text = "Puntaje Final: " + puntajeFinal;
    }
}