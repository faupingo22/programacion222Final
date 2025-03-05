using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemigo : MonoBehaviour
{
    public int da�o = 10;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {           
            col.GetComponent<JugadorVida>().RecibirDa�o(da�o);

            Destroy(gameObject);
        }
    }
}
