using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class movimento : MonoBehaviour
{
    //attributi
    Rigidbody2D player;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        player.velocity = new Vector2(dirX * 7f, player.velocity.y);
      
       if (dirX > 0f)
        {
            animator.SetBool("camminata", true);
        }
        else if(dirX < 0f)
        {
            animator.SetBool("camminata", true);
        }
       else
        {
            animator.SetBool("camminata", false);
        }
        if (dirX < -0.01f) transform.localScale = new Vector3(-1, 1, 1);
        if (dirX > 0.01f) transform.localScale = new Vector3(1, 1, 1);
    }

}

