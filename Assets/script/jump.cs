using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody2D player;
    [SerializeField] float jumpforce;
    [SerializeField] float gravityScale = 5;
    [SerializeField] float fallGravityScale = 15;

    bool grounded;



    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            player.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
        }
        if (player.velocity.y > 0)
        {
            player.gravityScale = gravityScale;
        }
        else
        {
            player.gravityScale = fallGravityScale;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }
}


