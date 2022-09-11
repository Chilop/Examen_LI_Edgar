using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Light luzdespot;
    [SerializeField] private Camera maincam;
    [SerializeField] private LayerMask mouseplane;
    public float movespeed;
    public float rotSpeed;
    public float fuerza;
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
        // para el mouse

        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;
            if(Physics.Raycast(ray,out raycastHit,Mathf.Infinity,mouseplane))
            {
                Debug.DrawLine(ray.origin, raycastHit.point, Color.green, 2f);
                if(raycastHit.collider.tag == "Clicks")
                {
                    Rigidbody esferarb = raycastHit.collider.GetComponent<Rigidbody>();
                    Vector3 direcciondelraycast = transform.transform.TransformDirection(Vector3.forward);
                    esferarb.AddForceAtPosition(direcciondelraycast * fuerza, raycastHit.point);
                }
            }
        }


    }

    // Codigo para las esferas 

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("EsferaAzul"))
        {
            Debug.Log("se toca la efera azul");
            luzdespot.color = Color.blue;
            maincam.cullingMask = LayerMask.GetMask("Default","Cubo3");
        }
        if (other.gameObject.CompareTag("EsferaAma"))
        {
            Debug.Log("se toca la efera amarilla");
            luzdespot.color = Color.yellow;
            maincam.cullingMask = LayerMask.GetMask("Default","Cubo2");
        }
        if (other.gameObject.CompareTag("EsferaRoja"))
        {
            Debug.Log("se toca la efera roja");
            luzdespot.color = Color.red;
            maincam.cullingMask = LayerMask.GetMask("Default","Cubo1");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        luzdespot.color = Color.white;
        maincam.cullingMask = LayerMask.GetMask("Default");
    }


    // codigo para el raton del mouse


}
