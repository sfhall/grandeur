using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public GameObject[] doors;
    public GameObject player;
    //this value is use to allow wiggle room for entering doors
    public float give;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    bool jump = false;
    bool crouch = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
        else if(Input.GetButtonDown("up"))
        {
            LoadLevel();
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);

    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    private void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    private void LoadLevel()
    {
        //check if in range of door and load approprate scene
        string[] doorNames = {"Level1", "Level2", "Level3", "Level4", "Level5", "Level6", "Level7", "Level8"};
        for(int i = 0; i < 8; i++)
        {
            //Debug.Log(doors[i].transform.localPosition);
            //subtract 10 for adjustment
            float compare = Mathf.Abs(player.transform.position.x - doors[i].transform.position.x);
            if(compare < give && compare > 0)
                SceneManager.LoadScene(doorNames[i]);
        }
        return;
    }
}
