using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    void Update()
    {   // Si el jugador presiona Escape, se cierra el juego
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void PlayerVSAI()
    {   // Carga la escena del modo contra IA
        SceneManager.LoadScene("PLAYERVSAI");
    }
    public void PlayerVSPlayer()
    {   // Carga la escena del modo 1 contra 1
        SceneManager.LoadScene("PLAYERVSPLAYER");
    }
}