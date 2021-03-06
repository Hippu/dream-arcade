﻿using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movespeed;
    public bool moveright;
    public bool moveleft;

    protected Animator animator;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = this.GetComponent<Animator>();

    }

    void Update()
    {

        //For keyboard:
        //Right:
        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetInteger("Direction", 1);
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetInteger("Direction", 0);
        }

        //Left:
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            animator.SetInteger("Direction", 2);
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {

            animator.SetInteger("Direction", 0);
        }


        //For touch controls:
        if (moveright) //Right
        {

            animator.SetInteger("Direction", 1);
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
        }
        if (moveleft) //Left
        {

            animator.SetInteger("Direction", 2);
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
        }
        //Idle
        if (!moveleft && !moveright && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
        {

            animator.SetInteger("Direction", 0);
        }
    }
}