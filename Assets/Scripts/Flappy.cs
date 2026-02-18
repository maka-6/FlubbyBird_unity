using UnityEngine;
using UnityEngine.InputSystem;

public class Flappy : MonoBehaviour
{
    public GestoreInput gestoreInput;
    Rigidbody2D rb;
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gestoreInput = new GestoreInput();
        gestoreInput.Enable();
        rb = GetComponent<Rigidbody2D>();
        gestoreInput.player.salta.performed += salta;
    }

    private void salta(InputAction.CallbackContext context)
    {
        rb.linearVelocity = Vector2.zero;
        rb.AddForce(Vector2.up*speed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        gestoreInput.Disable();
        GameController.instance.GameOver();
    }
}
