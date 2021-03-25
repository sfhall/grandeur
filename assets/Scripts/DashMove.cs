using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMove : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    private Rigidbody2D rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;
    public float dashRate = 1f;
    float nextDashTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextDashTime)
        {
            if (direction == 0)
            {
                if (Input.GetButtonDown("Dash"))
                {
                    direction = 1;

                    animator.SetInteger("IsDashing", direction);
                    animator.SetBool("IsJumping", false);
                }
            }
            else
            {
                if (dashTime <= 0)
                {
                    direction = 0;
                    dashTime = startDashTime;
                    rb.velocity = Vector2.zero;
                    animator.SetInteger("IsDashing", direction);
                    nextDashTime = Time.time + dashRate;
                }
                else
                {
                    dashTime -= Time.deltaTime;

                    if (controller.m_FacingRight == true)
                    {
                        rb.velocity = Vector2.right * dashSpeed;
                    }
                    else if (controller.m_FacingRight == false)
                    {
                        rb.velocity = Vector2.left * dashSpeed;
                    }


                    /*if(direction == 1)
                    {
                        rb.velocity = Vector2.left * dashSpeed;
                    }
                    else if(direction == 2)
                    {
                        rb.velocity = Vector2.right * dashSpeed;
                    }*/
                }
            }

        }
    }
}
