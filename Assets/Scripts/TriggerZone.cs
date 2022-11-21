using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GameEventsManager.current.EnterDoor_Events();
    }

    private void OnTriggerExit(Collider other)
    {
        GameEventsManager.current.ExitDoor_Events();
    }
}