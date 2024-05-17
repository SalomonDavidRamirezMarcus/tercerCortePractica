using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movimientoPersonajeLOL : MonoBehaviour
{
    public camara cam;
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit tiro;
            if (Physics.Raycast(ray, out tiro))
            {
                agent.SetDestination(tiro.point);
            }
        }

            
    }
}
