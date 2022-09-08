using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaAuto : MonoBehaviour
{
    public float elevacionspeed; 

    private void OnTriggerEnter(Collider other)
    {
      (new transform(0f, elevacionspeed, 0f) * Time.deltaTime).gameObject(new Vector3 (0f, elevacionspeed, 0f)*Time.deltaTime);
        Debug.Log("Se mueve la puerta");
    }
    private void OnTriggerExit(Collider other)
    {
        //other.gameObject.transform.Translate(new Vector3(0f, -elevacionspeed, 0f) * Time.deltaTime);
    }

}
