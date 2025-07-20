using TMPro;
using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour
{
    public int powerCellCount = 0;
    public CoroutineManager manager;

    public void AddPowerCell()
    {
        powerCellCount++;
        manager.ShowPickupCellMessage();
    }

    
}
