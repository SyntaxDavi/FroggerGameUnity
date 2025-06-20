using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float BaseSpeed = 0.008f;
    Rigidbody2D rb;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        WASDMovement();
    }

    private void WASDMovement()
    {
        if (rb != null)
        {
            float move_x = Input.GetAxisRaw("Horizontal");
            float move_y = Input.GetAxisRaw("Vertical");

            if(move_x != 0)
            {
                move_y = 0;
            }else if(move_y != 0)
            {
                move_x = 0;
            }

            Vector2 movement = new Vector2 (move_x, move_y).normalized * BaseSpeed;
            rb.linearVelocity = movement;
           
        }
    }
    
}
