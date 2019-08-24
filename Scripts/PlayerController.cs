using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 1;
    int count;


    void Start()
    {
        count = 0;
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

        Debug.Log("jumlah koin = " + count);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Koin"))
        {
            count+=1;
            Destroy(other.gameObject);
        }
        
    }
}
