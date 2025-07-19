using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public dodir_sa_igracem touch;
    public GameObject door;
    public GameObject doorSet;

    private bool canTeleport = true;
    private float teleportCooldown = 0.5f; // Half a second
    private float lastTeleportTime = -999f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!canTeleport || Time.time - lastTeleportTime < teleportCooldown)
            return;

        // Player touches entrance door
        if (collision.gameObject == door)
        {
            if (touch.pickupKey)
            {
                transform.position = doorSet.transform.position;
                canTeleport = false;
                lastTeleportTime = Time.time;
                Debug.Log("Teleported to doorSet");
            }
            else
            {
                Debug.Log("Door is locked");
            }
        }

        // Player touches destination door
        else if (collision.gameObject == doorSet)
        {
            Vector3 offset = new Vector3(0, -1f, 0);
            transform.position = door.transform.position + offset;
            canTeleport = false;
            lastTeleportTime = Time.time;
            Debug.Log("Teleported back to door");
        }
    }

    private void Update()
    {
        // Re-enable teleport after cooldown
        if (!canTeleport && Time.time - lastTeleportTime >= teleportCooldown)
        {
            canTeleport = true;
        }
    }
}
