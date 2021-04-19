using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    public float jumpRate = 4f;
    float nextJumpTime = 0f;

    int jump = 0;
    //bool doubleJump = false;
    bool crouch = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonUp("Jump") && animator.GetBool("IsJumping") == true)
        {
            Debug.Log("JumpButtonUp");
        }

        if (Input.GetButtonDown("Jump") && animator.GetBool("IsJumping") == false)
        {
            Debug.Log("JumpButtonDown1");
            jump = 1;
            animator.SetBool("IsJumping", true);
            //if (Time.time >= nextJumpTime)
            //{
                
            //}
        }
        else if (Input.GetButtonDown("Jump") && animator.GetBool("IsJumping") == true && Time.time >= nextJumpTime)
        {
            Debug.Log("JumpButtonDown2");
            jump = 2;
            animator.SetBool("CanDoubleJump", true);
            animator.SetBool("IsDoubleJumping", true);
        }
        

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
        animator.SetBool("CanDoubleJump", false);
        animator.SetBool("IsDoubleJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    private void FixedUpdate()
    {
        // Move our character
        if (jump == 1)
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        }
        if (jump == 2)
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
            Debug.Log("DoubleJump");
            nextJumpTime = Time.time + 4f / jumpRate;
        }
        else
            controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = 0;
    }

    
}
