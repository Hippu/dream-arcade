using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movespeed;
    public bool moveright;
    public bool moveleft;

    private Animator animator;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = this.GetComponent<Animator>();

    }

    void Update()
    {

        //For keyboard:
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
            animator.SetInteger("Direction", 2);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
            animator.SetInteger("Direction", 1);

        }

        //For touch controls:
        if (moveright)
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
        }
        if (moveleft)
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
        }
    }
}