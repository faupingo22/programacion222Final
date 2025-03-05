using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad = 10f;
    public int daño = 25;

    private Rigidbody2D rb;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            rb.velocity = transform.right * velocidad;

            Destroy(gameObject, 3f);
        }

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Enemigo"))
        {
            
            EnemigoVida enemigoVida = otro.GetComponent<EnemigoVida>();
            if (enemigoVida != null)
            {
                enemigoVida.RecibirDaño(daño);
            }

            Destroy(gameObject);
        }
    }
}
