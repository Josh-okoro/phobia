using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiggerObjectScript : MonoBehaviour
{

    public GameObject textHint;
    public AudioSource textSound;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            textHint.SetActive(true);
            textSound.Play();
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            textHint.SetActive(false);
            //textSound.Stop();
        }
    }


}
