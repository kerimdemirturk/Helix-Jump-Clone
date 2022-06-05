using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform ball;
    private Vector3 offset;
    public float smoothing;
    public new Vector3 smoothPozition;

    void Start()
    {
        offset = transform.position - ball.position + smoothPozition;
    }

   
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, offset + ball.position,smoothing);
        transform.position = newPos;
    }
}
