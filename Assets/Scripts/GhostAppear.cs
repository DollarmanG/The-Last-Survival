using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAppear : MonoBehaviour
{
    private Vector3 initialPosition;
    private AudioSource screamSound;

    void OnEnable()
    {
        GameEventsManager.current.onHasEnterDoor += Current_OnHasEnterDoor;
        GameEventsManager.current.onHasExitDoor += DoorExit;
    }

    void Current_OnHasEnterDoor()
    {
        OpenDoor();
    }

    private void Start()
    {
        initialPosition = transform.position;
        screamSound = GetComponent<AudioSource>();
        
    }


    void OpenDoor()
    {
        Debug.Log("Ok, Ghost appears!");
        screamSound.Play();
        transform.position = initialPosition + Vector3.up * 5.0f;
    }

    void DoorExit()
    {
        Debug.Log("Ok, Ghost dissapears!");
        transform.position = initialPosition;
    }
}
