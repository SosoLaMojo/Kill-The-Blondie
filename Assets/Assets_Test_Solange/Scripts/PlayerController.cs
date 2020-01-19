using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float maxSpeedJump = 200.0f;
    [SerializeField] private float speed;

    [SerializeField] private Rigidbody2D rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity += new Vector2(speed, 0);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private void Jump()
    {
        rigidBody.velocity += new Vector2(0, maxSpeedJump);
    }
}

