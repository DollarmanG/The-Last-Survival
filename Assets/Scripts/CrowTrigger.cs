using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowTrigger : MonoBehaviour
{
    private AudioSource crowSound;

    void Start()
    {
        crowSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            crowSound.Play();
        }
    }
}
