using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour {
	private Rigidbody2D physic;
	private States state;
	private Transform transform;

	public float acceleration;
	public float speedNormal;
	public float speedZombie;
	public float speedFeu;
	private float m_maxSpeed;
	// Use this for initialization
	void Start () {
		physic = gameObject.GetComponent<Rigidbody2D> ();
		state = gameObject.GetComponent<States>();
		transform = gameObject.GetComponent<Transform> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate(){

		if (Mathf.Abs (physic.velocity.x) < m_maxSpeed) {
			physic.AddForce (Vector2.right * acceleration * state.m_direction);
		}
	}
}
