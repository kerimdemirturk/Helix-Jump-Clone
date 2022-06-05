using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotating : MonoBehaviour
{
    public float rotatingSpeed;
    private float moveX;

    

    
    void Update()
    {
        moveX = Input.GetAxis("Mouse X");

        if(Input.GetMouseButton(0)) //Rotating cyle with mouse movement.
        {
            transform.Rotate(0, moveX*rotatingSpeed*Time.deltaTime, 0);
        }
    }
}
