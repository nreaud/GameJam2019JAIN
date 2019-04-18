using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class States : MonoBehaviour {

	public enum Etat {normal, glace, feu, zombie};
	public enum Type {poussin, poule, coq, super};

	//States
	public int m_direction = 1;//left -1, right 1, else 0
	public Etat m_etat = Etat.normal;
	public Type m_type = Type.poussin;
	// Use this for initialization

	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
