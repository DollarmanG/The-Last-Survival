using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventsManager : MonoBehaviour
{
    public event Action onHasEnterDoor;
    public event Action onHasExitDoor;

    public static GameEventsManager current;

    private void Awake()
    {
        current = this;
    }

    public void EnterDoor_Events()
    {
        onHasEnterDoor?.Invoke();
    }

    public void ExitDoor_Events()
    {
        onHasExitDoor?.Invoke();
    }
}
