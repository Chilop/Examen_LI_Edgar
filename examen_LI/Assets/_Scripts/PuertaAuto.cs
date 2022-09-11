using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PuertaAuto : MonoBehaviour
{
    

    [SerializeField] private GameObject puertaauto;
    [SerializeField] private float elevacionspeed;
    [SerializeField] private Rigidbody puertarb;
    private float limitedeelevacion = 6f;

    private void Start()
    {
       
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            
            
                Debug.Log("la puerta se eleva");
                puertarb.useGravity = false;
                puertaauto.transform.Translate(new Vector3(0f,limitedeelevacion,0f) * elevacionspeed * Time.deltaTime);

            

        }
    }


    private void OnTriggerExit(Collider other)
    {
        Debug.Log("la puerta se cierra");
        puertarb.useGravity = true;
        puertaauto.transform.Translate(Vector3.down * elevacionspeed* Time.deltaTime);
    }

}
