using UnityEngine;

public class Players : MonoBehaviour
{
    public bool player1; // Si es el jugador 1 (true), si no es el 2
    public float speed = 3; // Velocidad de movimiento
    public Rigidbody2D rb; // Rigidbody del jugador
    private float move; // Entrada de movimiento
    private Vector2 startPos; // Posición inicial
    void Start()
    {
        startPos = transform.position; // Guarda la posición inicial al comenzar
    }


    void Update()
    {   // Si es el jugador 1, usa la entrada Vertical (W/S o flechas ↑/↓)
        if (player1)
        {
            move = Input.GetAxisRaw("Vertical");
        }
        else
        { // Si es el jugador 2, usa otra entrada personalizada
            move = Input.GetAxisRaw("Vertical2");
        }   // Aplica velocidad en el eje Y
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, move * speed);
    }
    public void Reset()
    {
        rb.linearVelocity = Vector2.zero; // Detiene al jugador
        transform.position = startPos; // Lo devuelve a la posición inicial

    }
}
