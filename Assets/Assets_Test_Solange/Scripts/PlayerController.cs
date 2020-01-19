using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float maxSpeedJump = 200.0f;
    [SerializeField] private float speed;

    [SerializeField] private GameObject groundCheck;
    [SerializeField] private LayerMask layer;

    private Vector2 velocity;
    [SerializeField] private Rigidbody2D rigidBody;

    private void Start()
    {
        velocity = Vector2.zero;
        rigidBody = GetComponent<Rigidbody2D>();

        rigidBody.velocity += new Vector2(speed, 0);
    }

    private void Update()
    {
        // get value in the axes x and y
        float x = Input.GetAxisRaw("Horizontal");

        float y = 0;

        if (Input.GetButtonDown("Jump"))
        {
            y = 1;
        }

        velocity = new Vector2(x, y);

        Jump();
    }

    private void Jump()
    {
        bool grounded = Physics2D.OverlapBox(groundCheck.transform.position, new Vector3(0.32f, 0.06f, 0), layer);
        bool isGrounded = grounded && Mathf.Abs(rigidBody.velocity.y) <= 0.01f;

        if (isGrounded)
        {
            rigidBody.AddForce(new Vector2(0f, velocity.y) * Time.fixedDeltaTime * maxSpeedJump, ForceMode2D.Impulse);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(groundCheck.transform.position, new Vector3(0.32f, 0.06f, 0));
    }
}

