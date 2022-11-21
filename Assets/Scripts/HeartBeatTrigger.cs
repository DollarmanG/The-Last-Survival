using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBeatTrigger : MonoBehaviour
{
    private AudioSource heartbeatSound;

    void Start()
    {
        heartbeatSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            heartbeatSound.Play();
        }
    }
}
