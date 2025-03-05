using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;  
using System.Collections;

public class EnemigoKamikaze : MonoBehaviour
{
    public float velocidad = 15f;
    public float aceleracion = 5f; 
    public Rigidbody2D rb;
    private Transform jugador;
    private Vector2 direccion;

    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        if (jugador == null) return;

        
        Vector2 direccionActual = (jugador.position - transform.position).normalized;

        
        rb.velocity = Vector2.Lerp(rb.velocity, direccionActual * velocidad, aceleracion * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Player"))
        {
            
            SceneManager.LoadScene("GameOver");
        }
    }
}

