using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public bool drageable;

    void Start()
    {
        drageable = true;
    }

    private void OnMouseDrag()
    {
        if (drageable)
        {
            //When mousePos will be translated into world point it will keep z pos of object unchanged
            float fixedZPos = transform.position.z - Camera.main.transform.position.z;
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, fixedZPos);
            //Mouse Position has to be translated into world point
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }
    }

    //When playButton change state -> cannot be moved any longer + gain rigidbody (at the start doesnt have one)
}
