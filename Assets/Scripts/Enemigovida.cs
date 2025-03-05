using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoVida : MonoBehaviour
{
    public int vida = 50;
    public GameObject itemPrefab; 
    public int cantidadMin = 0; 
    public int cantidadMax = 5; 
    public float probabilidadDrop = 0.7f; 

    public void RecibirDaño(int cantidad)
    {
        vida -= cantidad;
        Debug.Log(gameObject.name + " recibió daño. Vida restante: " + vida);

        if (vida <= 0)
        {
            Morir();
        }
    }

    void Morir()
    {
        int cantidadItems = Random.Range(cantidadMin, cantidadMax + 1); 

        for (int i = 0; i < cantidadItems; i++)
        {
            if (Random.value < probabilidadDrop)
            {
                Instantiate(itemPrefab, transform.position, Quaternion.identity);
            }
        }

        Destroy(gameObject);
    }
}
