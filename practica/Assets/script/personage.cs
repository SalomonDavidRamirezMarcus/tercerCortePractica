using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class personage : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotationSpeed = 100f;
    private Rigidbody rb;


    public Animator anima;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate()
    {
        // movimeito
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = transform.forward * moveSpeed * verticalInput;

        Quaternion rotation = Quaternion.Euler(0f, horizontalInput * rotationSpeed * Time.fixedDeltaTime, 0f);
        
        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation * rotation);

        if (verticalInput > 0 || verticalInput < 0)
        {
            anima.SetFloat("walk", Mathf.Abs(verticalInput));

        }
        else
        {
            anima.SetFloat("walk", 0);
        }


    }


}
