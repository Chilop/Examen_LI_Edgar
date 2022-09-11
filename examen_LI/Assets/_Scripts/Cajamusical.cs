using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cajamusical : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip angel;
    [SerializeField] AudioClip Miku;
    [SerializeField] AudioClip Bruh;
    [SerializeField] AudioClip a;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TimerPausa()
    {
        yield return new WaitForSeconds(7);
        Debug.Log("se pone pausa");
        audioSource.Pause();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Vector3 vector3 = collision.GetContact(0).normal;
            if (vector3.x == 1f)
            {
                audioSource.PlayOneShot(Bruh);
               
            }
            if(vector3.x == -1f)
            {
                audioSource.PlayOneShot(a);
                
                
            }
            if(vector3.z == 1f)
            {
                audioSource.PlayOneShot(angel);
                StartCoroutine(TimerPausa());
            }
            if(vector3.z == -1f)
            {
                audioSource.PlayOneShot(Miku);
                StartCoroutine(TimerPausa());
               
            }
        }
            
        
    }
}
