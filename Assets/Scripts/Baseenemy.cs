using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baseenemy : MonoBehaviour
{
    public Transform jugador;
    public float velocidad = 2f;

    protected Rigidbody2D rb;

    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
    }

    protected virtual void FixedUpdate()
    {
        if (jugador != null)
        {
            Vector2 direccion = (jugador.position - transform.position).normalized;
            rb.velocity = direccion * velocidad;
        }
    }
}
