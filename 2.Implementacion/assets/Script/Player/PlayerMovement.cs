using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public Animator animator;
    public float runSpeed = 5f;
    float horizontalMove = 0f;
    bool jump = false;
    bool dash = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump") && controller.getGrounded() == true)
        {
            jump = true;
            animator.SetBool("isJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            dash = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            dash = false;
        }

    }
    
    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, dash, jump);
        jump = false;
       
    }

    public void OnDash(bool isDashing)
    {
        animator.SetBool("isDashing", isDashing);
    }
}