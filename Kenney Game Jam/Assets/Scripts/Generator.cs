using TMPro;
using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour
{
    public int powerCellCount = 0;
    public GameObject cell1;
    public GameObject cell2;
    public GameObject cell3;
    public CoroutineManager manager;
    public bool levelPassed;
    public AudioManager audioManager;

    public void AddPowerCell()
    {
        audioManager.PlaySFX(audioManager.itempickup);
        powerCellCount++;
        manager.ShowPickupCellMessage();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(powerCellCount == 1)
            {
                cell1.SetActive(true);
                audioManager.PlaySFX(audioManager.wire);
            }
            else if (powerCellCount == 2)
            {
                cell1.SetActive(true);
                cell2.SetActive(true);
                audioManager.PlaySFX(audioManager.wire);
            }
            else if (powerCellCount == 3)
            {
                cell1.SetActive(true);
                cell2.SetActive(true);
                cell3.SetActive(true);
                audioManager.PlaySFX(audioManager.wire);
                levelPassed = true;
            }
        }
    }

}
