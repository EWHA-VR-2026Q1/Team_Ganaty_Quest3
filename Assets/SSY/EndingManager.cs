using UnityEngine;
using TMPro;

public class EndingManager : MonoBehaviour
{
    public TextMeshProUGUI finalReportText;

    void Start()
    {
        if (finalReportText != null)
        {
            finalReportText.text = "Total Budget Spent: $" + CityData.totalCost.ToString("N0") + "\n" +
                                   "Total Time Spent: " + CityData.totalMonths + " Months";
        }
    }
}