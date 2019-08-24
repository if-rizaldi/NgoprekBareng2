using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 1;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //memasukan input
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //mendeklarasikan vektor move
        Vector2 move = new Vector2(moveHorizontal, moveVertical);

        //memasukan fungsi gerak
        Vector2 position = rb.position;
        position = position + move*speed;

        //eksekusi gerak
        rb.MovePosition(position);

    }
}
