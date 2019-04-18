using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startTestChickens : MonoBehaviour
{
    public bool state;
    // Start is called before the first frame update
    void Start()
    {
        state = false;   
    }

    //Not working 
    private void OnMouseEnter()
    {
        state = true;
    }
}
