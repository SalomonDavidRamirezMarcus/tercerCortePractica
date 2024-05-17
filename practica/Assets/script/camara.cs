using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public float sensiMouse = 3.0f;

    private float rotY, rotX;
    public Transform target;
    public float distanciaTarget = 3.0f;
    Vector3 curRotation;
    Vector3 smothVelocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal Ray ScreenPointToRay(Vector3 mousePosition)
    {
        throw new NotImplementedException();
    }
}
