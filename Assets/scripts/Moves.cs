using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour {
	private Rigidbody2D physic;
	private States state;

	public float acceleration;
	public float speedNormal;
	public float speedZombie;
	public float speedFeu;
	public float speedGlace;
	private float m_maxSpeed;
	// Use this for initialization
	void Start () {
		physic = gameObject.GetComponent<Rigidbody2D> ();
		state = gameObject.GetComponent<States>();
	}

	// Update is called once per frame
	void Update () {
		if(States.Etat.normal == state.m_etat)
		{
			m_maxSpeed = speedNormal;
		}
		else if (States.Etat.glace == state.m_etat)
		{
			m_maxSpeed = speedGlace;
		}
		else if (States.Etat.feu == state.m_etat)
		{
			m_maxSpeed = speedFeu;
		}
		else if (States.Etat.zombie == state.m_etat)
		{
			m_maxSpeed = speedZombie;
		}
		else
		{
			m_maxSpeed = 0;
		}
	}

	void FixedUpdate(){
		if (Mathf.Abs (physic.velocity.x) < m_maxSpeed) {
			physic.AddForce (Vector2.right * acceleration * state.m_direction);
		}
	}
}
