using System.Collections;
using UnityEngine;

public class EnemigoDisparo : MonoBehaviour
{
    public GameObject balaPrefab;
    public Transform puntoDisparo;

    public float tiempoEntreDisparos = 1f;
    public float velocidadBalaNormal = 30f;

    public float tiempoEntreRafagas = 6f;
    public float velocidadBalaRafaga = 10f;
    public int cantidadDisparosRafaga = 36;

    public float tiempoEntreEspiral = 8f;
    public float velocidadBalaEspiral = 5f;
    public int cantidadDisparosEspiral = 36;
    public float delayEntreBalasEspiral = 0.05f; 

    public Transform jugador;
    private bool enModoRafaga = false;
    private bool enModoEspiral = false;
    private float anguloEspiral = 0f; 

    void Start()
    {
        StartCoroutine(ControlDisparo());
    }

    IEnumerator ControlDisparo()
    {
        while (true)
        {
            if (!enModoRafaga && !enModoEspiral)
            {
                DispararHaciaJugador();
                yield return new WaitForSeconds(tiempoEntreDisparos);
            }
            else if (enModoRafaga)
            {
                DispararRafaga();
                yield return new WaitForSeconds(tiempoEntreRafagas);
                enModoRafaga = false;
            }
            else if (enModoEspiral)
            {
                yield return StartCoroutine(DispararEspiral());
                enModoEspiral = false;
            }

            float rand = Random.value;
            if (rand < 0.3f)
            {
                enModoRafaga = true;
            }
            else if (rand < 0.6f)
            {
                enModoEspiral = true;
            }
            else
            {
                yield return new WaitForSeconds(1f); 
            }
        }
    }


    void DispararHaciaJugador()
    {
        if (jugador == null) return;

        Vector3 direccion = (jugador.position - puntoDisparo.position).normalized;

        GameObject nuevaBala = Instantiate(balaPrefab, puntoDisparo.position, Quaternion.identity);
        Rigidbody2D rbBala = nuevaBala.GetComponent<Rigidbody2D>();
        if (rbBala != null)
        {
            rbBala.velocity = direccion * velocidadBalaNormal;
        }

        float angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;
        nuevaBala.transform.rotation = Quaternion.Euler(0f, 0f, angulo);
    }

    void DispararRafaga()
    {
        for (int i = 0; i < cantidadDisparosRafaga; i++)
        {
            float angulo = i * (360f / cantidadDisparosRafaga);
            DispararBala(angulo, velocidadBalaRafaga);
        }
    }

    IEnumerator DispararEspiral()
    {
        for (int i = 0; i < cantidadDisparosEspiral; i++)
        {
            DispararBala(anguloEspiral, velocidadBalaEspiral);
            anguloEspiral += 10f; 
            yield return new WaitForSeconds(delayEntreBalasEspiral);
        }
    }

    void DispararBala(float angulo, float velocidad)
    {
        Quaternion rotacion = Quaternion.Euler(0, 0, angulo);
        Vector2 direccion = rotacion * Vector2.right;

        GameObject bala = Instantiate(balaPrefab, puntoDisparo.position, Quaternion.identity);
        bala.GetComponent<Rigidbody2D>().velocity = direccion * velocidad;
    }
}





