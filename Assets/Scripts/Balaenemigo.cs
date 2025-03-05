using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemigo : MonoBehaviour
{
    public int daño = 10;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {           
            col.GetComponent<JugadorVida>().RecibirDaño(daño);

            Destroy(gameObject);
        }
    }
}
