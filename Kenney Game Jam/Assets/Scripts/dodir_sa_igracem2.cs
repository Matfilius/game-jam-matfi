using UnityEngine;

public class dodir_sa_igracem2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool pickupNotes = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            pickupNotes = true;
        }
    }
}
