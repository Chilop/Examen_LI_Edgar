using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   public float movespeed;

    public float rotSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //creacion de las funciones de movimiento
       // transform.Translate(new Vector3(0f,0f,movespeed)*Time.deltaTime);
       // funcion de rotacion 
      // transform.Rotate(new Vector3(0f,rotSpeed,0f)*Time.deltaTime);

        if(Input.GetKey(KeyCode.W))
        {

        transform.Translate(new Vector3(0f,0f, movespeed)* Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.S))
        {
               transform.Translate(new Vector3(0f,0f,-movespeed)* Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0f, -rotSpeed, 0f) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0f, rotSpeed, 0f) * Time.deltaTime);
        }

    }
}
