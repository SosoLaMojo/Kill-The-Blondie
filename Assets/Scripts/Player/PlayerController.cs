﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float maxSpeedJump = 200.0f;
    [SerializeField] private float speed;

    [SerializeField] private Rigidbody2D rigidBody;

    [SerializeField] private GameObject losePanelUI;

    private bool isGrounded = false;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity += new Vector2(speed, 0);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rigidBody.velocity += new Vector2(0, maxSpeedJump);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.layer == LayerMask.NameToLayer("Bodyguard"))
        {
            Destroy(gameObject);
            ActivateLosePanel();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    public void ActivateLosePanel()
    {
        losePanelUI.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
}

