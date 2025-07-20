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
    private bool cell1Done;
    private bool cell2Done;
    private bool cell3Done;
    public AudioManager audioManager;
    public Bar barScript;

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
                if (!cell1Done)
                {
                    cell1.SetActive(true);
                    audioManager.PlaySFX(audioManager.wire);
                    cell1Done = true;
                }
            }
            else if (powerCellCount == 2)
            {
                if (!cell2Done)
                {
                    cell1.SetActive(true);
                    cell2.SetActive(true);
                    audioManager.PlaySFX(audioManager.wire);
                    cell2Done = true;
                }
            }
            else if (powerCellCount == 3)
            {
                if(!cell3Done)
                {
                    cell1.SetActive(true);
                    cell2.SetActive(true);
                    cell3.SetActive(true);
                    audioManager.PlaySFX(audioManager.wire);
                    cell3Done = true;
                    levelPassed = true;
                }
            }
        }
    }

}
