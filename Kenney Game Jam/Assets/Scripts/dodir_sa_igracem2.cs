using TMPro;
using UnityEngine;

public class dodir_sa_igracem2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool pickupCard = false;
    public GameObject card;
    public TextMeshProUGUI cardPickup;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            pickupCard = true;
            card.SetActive(false);
        }
    }

}
