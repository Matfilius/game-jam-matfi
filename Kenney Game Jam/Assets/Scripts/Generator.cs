using TMPro;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int powerCellCount = 0;
    public TextMeshProUGUI cellPickup;

    public void AddPowerCell()
    {
        Debug.Log("dodano");
        powerCellCount++;
    }
}
