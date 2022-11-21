using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Wolf : MonoBehaviour
{
    
    private AudioSource wolfSound;

    void Start()
    {
        wolfSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            wolfSound.Play();
        }
    }
}