using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public GameObject ball; // Referencia a la pelota
    public GameObject player1; // Jugador 1
    public GameObject player1Goal; // Meta del jugador 1
    public GameObject player2; // Jugador 2
    public GameObject player2Goal; // Meta del jugador 2
    public TextMeshProUGUI player1Text; // Puntuación del jugador 1
    public TextMeshProUGUI player2Text; // Puntuación del jugador 2

    private int player1Score; // Marcador jugador 1
    private int player2Score; // Marcador jugador 2
    public bool AIGame; // Si se juega contra la IA
    public int maxScore = 3; // Puntuación máxima para ganar
    public void CheckVictory()
    {   // Si el jugador 1 llega a la puntuación máxima, gana el jugador 2 (meta del jugador 1 fue alcanzada)
        if (player1Score >= maxScore)
        {
            SceneManager.LoadScene("VictoryPlayer2");
        }
        // Si el jugador 2 llega a la puntuación máxima, gana el jugador 1
        if (player2Score >= maxScore)
        {
            SceneManager.LoadScene("VictoryPlayer1");
        }
    }
    public void Player1Scored()
    {
        player1Score++; // Aumenta puntuación jugador 1
        player1Text.text = player1Score.ToString(); // Actualiza el texto en pantalla
        CheckVictory(); // Verifica si alguien ganó
        ResetPosition(); // Resetea la pelota y jugadores
    }
    public void Player2Scored()
    {
        player2Score++;
        player2Text.text = player2Score.ToString();
        CheckVictory();
        ResetPosition();
    }
    private void ResetPosition()
    {
        // Si se juega contra IA, solo se reinicia jugador 2 (controlado por IA)
        if (AIGame)
        {
            ball.GetComponent<Ball>().Reset();
            player2.GetComponent<Players>().Reset();
        }
        else // Jugador vs Jugador, ambos se resetean
        {
            ball.GetComponent<Ball>().Reset();
            player1.GetComponent<Players>().Reset();
            player2.GetComponent<Players>().Reset();
        }
    }
}
