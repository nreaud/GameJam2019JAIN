using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingPointController : MonoBehaviour
{

    public Text winText;
    // Start is called before the first frame update
    void Start()
    {
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        winText.text = "Ez Win GG my man!";
    }
}
