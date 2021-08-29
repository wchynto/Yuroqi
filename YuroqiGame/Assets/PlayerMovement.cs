using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D rb;
	public float speed;
	Animator anim;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator> ();
	}

	void Update()
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
	}
}
