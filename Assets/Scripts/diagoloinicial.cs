using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogoInicio : MonoBehaviour
{
    public GameObject panelDialogo; 
    public Image imagenPersonaje;   
    public TMP_Text textoDialogo;   

    public Sprite personajeSprite; 
    public string mensaje = "¡Bienvenido al juego!";
    public float tiempoVisible = 3f; 

    void Start()
    {
        StartCoroutine(MostrarDialogo());
    }

    IEnumerator MostrarDialogo()
    {
       
        panelDialogo.SetActive(true);

        
        imagenPersonaje.sprite = personajeSprite;
        textoDialogo.text = mensaje;

        
        yield return new WaitForSeconds(tiempoVisible);

        
        panelDialogo.SetActive(false);
    }
}
