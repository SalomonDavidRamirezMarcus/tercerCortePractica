using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class looprotation : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relpos =  target.position - transform.position;
        transform.rotation= Quaternion.LookRotation(relpos);

        
    }
}
