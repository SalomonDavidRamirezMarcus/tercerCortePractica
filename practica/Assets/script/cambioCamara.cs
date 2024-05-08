using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambioCamara : MonoBehaviour
{
    public CinemachineVirtualCamera activeCamara;
    public int numCam;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            activeCamara.Priority = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            activeCamara.Priority = 0;
        }
    }

}
