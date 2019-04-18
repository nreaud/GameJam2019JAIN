using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonController : MonoBehaviour
{
    public bool start;
    private Object[] poulets;
    // Start is called before the first frame update
    void Start()
    {
        start = false;   
    }   

    private void OnMouseDown()
    {
        start = true;
        GameObject[] chickens = GameObject.FindGameObjectsWithTag("Chicken");
        Debug.Log("Chickens: " + chickens);
        foreach (GameObject chicken in chickens){
            Debug.Log("Chicken: " + chicken);
            chicken.GetComponent<Moves>().enabled = true;
        }

        GameObject[] objects = GameObject.FindGameObjectsWithTag("Object");
        Debug.Log("Objects: " + objects);
        foreach (GameObject o in objects)
        {
            Debug.Log("Object: " + o);
            o.GetComponent<ObjectController>().drageable = false;
        }
    }


}
