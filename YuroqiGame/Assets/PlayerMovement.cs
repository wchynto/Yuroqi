using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D rb;
	public float speed;
	Animator anim;
	public float force;
    public bool isGrounded = true;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator> ();
	}

	void FixedUpdate()
	{
        float keyX = Input.GetAxisRaw ("Horizontal");
		rb.velocity = new Vector2 (keyX * speed * Time.deltaTime, rb.velocity.y);

		if (keyX > 0) 
		{
			anim.SetBool ("isRunning", true);
			transform.rotation = Quaternion.Euler (0f, 0f, 0f);
		}

		else if (keyX < 0) {
			anim.SetBool ("isRunning", true);
			transform.rotation = Quaternion.Euler (0f, -180f, 0f);
		} 

		else 
		{
			anim.SetBool ("isRunning", false);
		}


        Jump();
	}

	void Jump()
	{
		if (Input.GetKey(KeyCode.Space) && isGrounded)
		{
            rb.AddForce(new Vector2(0f, force * Time.deltaTime), ForceMode2D.Impulse);
            isGrounded = false;
		}
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            isGrounded = true;
        }
    }



}
