using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 7; // Velocidad con la que se lanza la pelota
    public Rigidbody2D rb; // Referencia al Rigidbody2D para aplicar velocidad
    private Vector2 startPos; // Posición inicial de la pelota
    void Start()
    {
        transform.position = startPos; // Coloca la pelota en su posición inicial
        Launch(); // Lanza la pelota
    }
    public void Reset()
    {
        transform.position = startPos; // Resetea la posición
        rb.linearVelocity = Vector2.zero; // Detiene la pelota
        Launch(); // Vuelve a lanzarla
    }

    public void Launch()
    {   // Genera una dirección aleatoria entre -1 y 1 para X e Y
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        // Aplica la velocidad a la pelota
        rb.linearVelocity = new Vector2(speed * x, speed * y);
    }
}
