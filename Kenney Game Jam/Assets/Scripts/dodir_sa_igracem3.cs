using TMPro;
using UnityEngine;

public class dodir_sa_igracem3 : MonoBehaviour
{
    public Generator generator;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            generator.AddPowerCell();
            Destroy(gameObject);
        }
    }

}
