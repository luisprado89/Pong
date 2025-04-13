using UnityEngine;

public class Players : MonoBehaviour
{
    public bool player1;
    public float speed = 3;
    public Rigidbody2D rb;
    private float move;
    private Vector2 startPos;
    void Start()
    {
        startPos = transform.position;
    }


    void Update()
    {
        if(player1){
            move = Input.GetAxisRaw("Vertical");
        }else{
            move = Input.GetAxisRaw("Vertical2");
        }
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, move * speed);
    }
    public void Reset()
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = startPos;

    }
}
