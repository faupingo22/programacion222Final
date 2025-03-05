using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlVictoria : MonoBehaviour
{
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Enemigo").Length == 0)
        {
            
            PlayerPrefs.SetInt("PuntajeFinal", GameManager.instance.ObtenerPuntuacion());
            PlayerPrefs.Save();

            
            SceneManager.LoadScene("Victoria");
        }
    }   
}