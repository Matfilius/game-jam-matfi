using UnityEngine;
using TMPro;
using System.Collections;

public class CoroutineManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public dodir_sa_igracem kljuc;
    public TextMeshProUGUI keyPickup;
    private bool keyShowed = false;

    private void Update()
    {
        if (kljuc.pickupKey && !keyShowed)
        {
            ShowPickupKeyMessage();
            keyShowed = true;
        }
    }


    private void ShowPickupKeyMessage()
    {
        StopAllCoroutines();
        StartCoroutine(FadeInAndOutTMP());
    }

    private IEnumerator FadeInAndOutTMP()
    {
        Color originalColor = keyPickup.color;

        // Fade in
        float fadeInTime = 0.5f;
        float t = 0f;
        while (t < fadeInTime)
        {
            t += Time.deltaTime;
            float alpha = Mathf.Lerp(0f, 1f, t / fadeInTime);
            keyPickup.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
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
            keyPickup.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            yield return null;
        }
        keyPickup.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);
    }
}
