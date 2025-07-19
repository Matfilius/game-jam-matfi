using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public dodir_sa_igracem touch;
    public GameObject Player;
    public GameObject doorSet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (touch.pickupKey)
            {
                
            }
            else
            {

            }
        }
    }
}
