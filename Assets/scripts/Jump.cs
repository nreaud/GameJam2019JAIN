using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
	private Rigidbody2D physic;
	private States state;

	public float jumpForce = 40;
	// Use this for initialization
	void Start () {
		physic = gameObject.GetComponent<Rigidbody2D> ();
		state = gameObject.GetComponent<States>();
	}

	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate(){
		if(!state.isJumping)
		{
			physic.AddForce (Vector2.up * jumpForce);
		}
	}

	void OnCollisionEnter2D(Collision2D hit)
	{
		if(hit.gameObject.tag == "platform")
  	{
			state.isJumping = false;
		}
 	}

	void OnCollisionExit2D(Collision2D hit)
	{
		if(hit.gameObject.tag == "platform")
  	{
			state.isJumping = true;
		}
 	}
}
