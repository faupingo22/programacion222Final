using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; 

    public int puntuacion = 0; 
    public Text puntuacionTexto; 

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AgregarPuntuacion(int cantidad)
    {
        puntuacion += cantidad;
        puntuacionTexto.text = "Puntos: " + puntuacion; 
    }
    
    public int ObtenerPuntuacion()
    {
        return puntuacion;
    }

}
