using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slerrp : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 relpos = (target.position + new Vector3(0,2f,0) - transform.position);
        Quaternion rot = Quaternion.LookRotation(relpos);


        Quaternion current = transform.localRotation;

        transform.localRotation =  Quaternion.Slerp(current, rot , Time.deltaTime);
         transform.Translate(0,0,5 * Time.deltaTime);   
        
    }
}
