using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorDisparo : MonoBehaviour
{
    public GameObject balaPrefab;
    public Transform puntoDisparo;
    public float tiempoEntreDisparos = 0.5f;
    private float tiempoUltimoDisparo;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= tiempoUltimoDisparo + tiempoEntreDisparos)
        {
            Disparar();
            tiempoUltimoDisparo = Time.time;
        }
    }

    void Disparar()
    {
        Debug.Log("Disparando...");        
        Vector3 posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicionMouse.z = 0f;

        Vector2 direccion = (posicionMouse - puntoDisparo.position).normalized;

        GameObject nuevaBala = Instantiate(balaPrefab, puntoDisparo.position, Quaternion.identity);
        Debug.Log("Bala creada en: " + puntoDisparo.position); 

        Rigidbody2D rbBala = nuevaBala.GetComponent<Rigidbody2D>();
        rbBala.velocity = direccion * 10f; 

        float angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;
        nuevaBala.transform.rotation = Quaternion.Euler(0f, 0f, angulo);
    }
}