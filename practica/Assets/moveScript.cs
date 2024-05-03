using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class moveScript : MonoBehaviour
{
    public float sensiMouse = 100f;
    public Transform cuerpojugador;

    float rotaX = 0f;


    // Start is called before the first frame update
    void Start()
    {
        // bloqueamos la posicion del mouse  y lo desaparecemo de la pantalla 
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        //capturamos los vlaores de movimieto del mouse 
        float mouseX = Input.GetAxis("Mouse X") * sensiMouse * Time.deltaTime;
        float mouseY = Input.GetAxis ("Mouse Y") * sensiMouse * Time.deltaTime;


        //rotamos nuestra camara en el eje x, se usa el - para evitar 
        //el invert axis
        rotaX -= mouseY;

        // restriccion  de la rotacion de la camara 90 y -90 grados 

        rotaX = Mathf.Clamp(rotaX, -90f, 90f);

        // asignaoms los valores  resultantes  de la rotacion de la camara  al objeto  como tal 

        transform.localRotation =  Quaternion.Euler(rotaX,0f,0f);

        cuerpojugador.Rotate(Vector3.up * mouseX);
    }
}
