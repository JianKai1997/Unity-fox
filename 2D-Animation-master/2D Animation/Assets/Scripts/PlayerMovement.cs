using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
    Rigidbody2D rb;
	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
    bool allowDoubleJump = false;
    bool onTheGround = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //background music
        FindObjectOfType<AudioManager>().Play("Background");
    }

	// Update is called once per frame
	void Update () {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        //jump + double jump
        if (rb.velocity.y == 0)
        {
            onTheGround = true;
        } 
        else
        {
            onTheGround = false;
        }

		if (Input.GetButtonDown("Jump") && onTheGround)
		{
            jumping();
            allowDoubleJump = true;
            jump = true;
			animator.SetBool("IsJumping", true);
		}
        else if (Input.GetButtonDown("Jump") && allowDoubleJump)
        {
            jumping();
            jump = true;
            animator.SetBool("IsJumping", true);
            allowDoubleJump = false;
        }

        //crouch
		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		}
        else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}
	}

	public void OnLanding ()
	{
		animator.SetBool("IsJumping", false);
	}

	public void OnCrouching (bool isCrouching)
	{
		animator.SetBool("IsCrouching", isCrouching);
	}

    public void jumping()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0f);
        rb.AddForce(Vector2.up * 600f);
    }

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
	}

}
