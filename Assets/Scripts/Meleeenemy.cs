using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMelee : MonoBehaviour
{
    public float velocidad = 14f;  
    public int daño = 250; 

    private Transform jugador;  

    private void Start()
    {
        jugador = GameObject.FindWithTag("Player").transform;  
    }

    private void Update()
    {
        if (jugador != null)
        {
            
            transform.position = Vector2.MoveTowards(transform.position, jugador.position, velocidad * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.CompareTag("Player"))
        {
            col.gameObject.GetComponent<JugadorVida>().RecibirDaño(daño);
        }
    }
}
