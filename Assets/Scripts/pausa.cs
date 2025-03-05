using UnityEngine;
using UnityEngine.UI; 

public class PausaJuego : MonoBehaviour
{
    public GameObject menuPausa;  

    private bool juegoPausado = false;  

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (juegoPausado)
            {
                ReanudarJuego();
            }
            else
            {
                PausarJuego();
            }
        }
    }

    public void PausarJuego()
    {       
        Time.timeScale = 0f;  
        juegoPausado = true;
        menuPausa.SetActive(true);
    }

    public void ReanudarJuego()
    {
        
        Time.timeScale = 1f;  
        juegoPausado = false;

        
        menuPausa.SetActive(false);
    }

    
    public void SalirDelJuego()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Detiene el juego en el editor
#else
        Application.Quit(); 
#endif
    }
}
