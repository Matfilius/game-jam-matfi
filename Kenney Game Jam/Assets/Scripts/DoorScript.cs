using UnityEngine;
using TMPro;
using System.Collections;

public class DoorScript : MonoBehaviour
{
    public dodir_sa_igracem touch;
    public KeyPad pad;
    public dodir_sa_igracem2 karta;
    public GameObject door;
    public GameObject doorSet;
    public GameObject door1;
    public GameObject doorSet1;
    public GameObject door2;
    public GameObject doorSet2;
    public TextMeshProUGUI needKey;
    public TextMeshProUGUI hasKey;

    private bool unlockedDoor = false;
    private bool unlockedDoor1 = false;
    private bool unlockedDoor2 = false;

    private bool canTeleport = true;
    private float teleportCooldown = 0.5f;
    private float lastTeleportTime = -999f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!canTeleport || Time.time - lastTeleportTime < teleportCooldown)
            return;

        if (collision.gameObject == door)
        {
            if (touch.pickupKey)
            {
                transform.position = doorSet.transform.position;
                canTeleport = false;
                lastTeleportTime = Time.time;
                Debug.Log("Teleported to doorSet");
                if (!unlockedDoor)
                {
                    ShowHasKeyMessage();
                    unlockedDoor = true;
                }
            }
            else
            {
                Debug.Log("Door is locked");
                ShowNeedKeyMessage();
            }
        }
        else if (collision.gameObject == doorSet)
        {
            Vector3 offset = new Vector3(0, -1f, 0);
            transform.position = door.transform.position + offset;
            canTeleport = false;
            lastTeleportTime = Time.time;
            Debug.Log("Teleported back to door");
        }
        else if (collision.gameObject == door1)
        {
            Debug.Log("Ajmo momci");
            if (pad.canEnter)
            {
                transform.position = doorSet1.transform.position;
                canTeleport = false;
                lastTeleportTime = Time.time;
                Debug.Log("Teleported to doorSet");
                if (!unlockedDoor1)
                {
                    ShowHasKeyMessage();
                    unlockedDoor1 = true;
                }
            }
            else
            {
                Debug.Log("Door is locked");
                ShowNeedKeyMessage();
            }
        }
        else if (collision.gameObject == doorSet1)
        {
            Vector3 offset = new Vector3(0, -1f, 0);
            transform.position = door1.transform.position + offset;
            canTeleport = false;
            lastTeleportTime = Time.time;
            Debug.Log("Teleported back to door");
        }
        else if (collision.gameObject == door2)
        {
            Debug.Log("Ajmo momci");
            if (karta.pickupCard)
            {
                transform.position = doorSet2.transform.position;
                canTeleport = false;
                lastTeleportTime = Time.time;
                Debug.Log("Teleported to doorSet");
                if (!unlockedDoor2)
                {
                    ShowHasKeyMessage();
                    unlockedDoor2 = true;
                }
            }
            else
            {
                Debug.Log("Door is locked");
                ShowNeedKeyMessage();
            }
        }
        else if (collision.gameObject == doorSet2)
        {
            Vector3 offset = new Vector3(0, -1f, 0);
            transform.position = door2.transform.position + offset;
            canTeleport = false;
            lastTeleportTime = Time.time;
            Debug.Log("Teleported back to door");
        }
    }

    private void Update()
    {
        if (!canTeleport && Time.time - lastTeleportTime >= teleportCooldown)
        {
            canTeleport = true;
        }
    }

    private void ShowNeedKeyMessage()
    {
        StopAllCoroutines();
        StartCoroutine(FadeInAndOutTMP());
    }

    private void ShowHasKeyMessage()
    {
        StopAllCoroutines();
        StartCoroutine(FadeInAndOutTMP2());
    }

    private IEnumerator FadeInAndOutTMP()
    {
        Color originalColor = needKey.color;

        // Fade in
        float fadeInTime = 0.5f;
        float t = 0f;
        while (t < fadeInTime)
        {
            t += Time.deltaTime;
            float alpha = Mathf.Lerp(0f, 1f, t / fadeInTime);
            needKey.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            yield return null;
        }

        // Hold
        yield return new WaitForSeconds(2f);

        // Fade out
        float fadeOutTime = 1f;
        t = 0f;
        while (t < fadeOutTime)
        {
            t += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, t / fadeOutTime);
            needKey.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            yield return null;
        }
        needKey.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);
    }

    private IEnumerator FadeInAndOutTMP2()
    {
        Color originalColor = hasKey.color;

        // Fade in
        float fadeInTime = 0.5f;
        float t = 0f;
        while (t < fadeInTime)
        {
            t += Time.deltaTime;
            float alpha = Mathf.Lerp(0f, 1f, t / fadeInTime);
            hasKey.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            yield return null;
        }

        // Hold
        yield return new WaitForSeconds(2f);

        // Fade out
        float fadeOutTime = 1f;
        t = 0f;
        while (t < fadeOutTime)
        {
            t += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, t / fadeOutTime);
            hasKey.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            yield return null;
        }
        hasKey.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);
    }
}
