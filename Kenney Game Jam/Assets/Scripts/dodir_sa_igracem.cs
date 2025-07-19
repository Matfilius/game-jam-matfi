using UnityEngine;
using TMPro;
using System.Collections;

public class dodir_sa_igracem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public bool pickupKey = false;
    public GameObject key;
    public TextMeshProUGUI keyPickup;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            pickupKey = true;
            key.SetActive(false);
        }
    }

    

}
