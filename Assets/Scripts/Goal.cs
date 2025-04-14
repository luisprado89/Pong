using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool player1Goal; // Indica si esta es la meta del jugador 1
    public GameObject gameManager; // Referencia al GameManager
    private void OnTriggerEnter2D(Collider2D collision)
    {   // Si lo que colisiona es la pelota
        if (collision.CompareTag("Ball"))
        {
            Debug.Log("¡Gol!");// Muestra mensaje en consola
            if (player1Goal) // Si es la portería del jugador 1, anota el jugador 2
            {
                gameManager.GetComponent<GameManager>().Player1Scored();
            }
            else // Si es la del jugador 2, anota el jugador 1
            {
                gameManager.GetComponent<GameManager>().Player2Scored();
            }
        }
    }

}
