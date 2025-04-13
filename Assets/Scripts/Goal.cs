using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool player1Goal;
    public GameObject gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            Debug.Log("¡Gol!");
            if (player1Goal)
            {
                gameManager.GetComponent<GameManager>().Player1Scored();
            }
            else
            {
                gameManager.GetComponent<GameManager>().Player2Scored();
            }
        }
    }

}
