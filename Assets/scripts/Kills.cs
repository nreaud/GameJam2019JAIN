using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kills : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
		
    }
	
	void OnCollisionEnter2D(Collision2D hit)
	{
		if(hit.gameObject.tag == "poulet")
		{
			hit.gameObject.GetComponent<States>().m_etat = States.Etat.mort;
		}
	}
}
