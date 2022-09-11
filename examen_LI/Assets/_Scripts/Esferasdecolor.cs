using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esferasdecolor : MonoBehaviour
{

    [SerializeField] private Light luzdespot;
    [SerializeField] private Camera maincam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("EsferaAzul"))
        {
            Debug.Log("se toca la efera azul");
            luzdespot.color = Color.blue;
            maincam.cullingMask = LayerMask.GetMask("Cubo1");
        }
        if(other.gameObject.CompareTag("EsferaAma"))
        {
            Debug.Log("se toca la efera amarilla");
            luzdespot.color = Color.yellow;
            maincam.cullingMask = LayerMask.GetMask("Cubo2");
        }
        if(other.gameObject.CompareTag("EsferaRoja"))
        {
            Debug.Log("se toca la efera roja");
            luzdespot.color = Color.red;
            maincam.cullingMask = LayerMask.GetMask("Cubo3");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        luzdespot.color = Color.white;
        maincam.cullingMask = LayerMask.GetMask("Default");
    }


}
