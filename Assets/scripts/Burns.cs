using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burns : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerExit2D(Collider2D hit)
	{
		if(hit.gameObject.tag == "poulet")
		{
			if(hit.gameObject.GetComponent<States>().m_etat == States.Etat.normal)
			{
				hit.gameObject.GetComponent<States>().m_etat = States.Etat.feu;
			}
			else if (hit.gameObject.GetComponent<States>().m_etat == States.Etat.glace)
			{
				hit.gameObject.GetComponent<States>().m_etat = States.Etat.normal;
			}
			else if (hit.gameObject.GetComponent<States>().m_etat == States.Etat.zombie)
			{
				hit.gameObject.GetComponent<States>().m_etat = States.Etat.mort;
			}
		}
	}
}
