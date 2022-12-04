using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundscript : MonoBehaviour
{

    AudioSource puansesi;
    
    void Start()
    {
        puansesi = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            puansesi.Play();
        }


    }
}