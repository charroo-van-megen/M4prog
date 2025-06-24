using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Speler klaar!");
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        Vector3 velocity = rb.linearVelocity;
        velocity.x = move * moveSpeed;
        rb.linearVelocity = velocity;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            foreach (ContactPoint contact in collision.contacts)
            {
                if (Vector3.Dot(contact.normal, Vector3.up) > 0.5f)
                {
                    isGrounded = true;
                    break;
                }
            }
        }
    }
}
