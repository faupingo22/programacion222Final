using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramovement : MonoBehaviour
{
    public Transform jugador;
    public float suavizado = 0.1f;
    private Vector3 velocidad = Vector3.zero;

    void LateUpdate()
    {
        if (jugador != null)
        {
            Vector3 posicionObjetivo = new Vector3(jugador.position.x, jugador.position.y, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, posicionObjetivo, ref velocidad, suavizado);
        }
    }
}
