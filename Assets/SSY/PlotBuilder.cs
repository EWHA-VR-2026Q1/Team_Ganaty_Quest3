using UnityEngine;

public class PlotBuilder : MonoBehaviour
{
    public GameObject[] buildings;

    [Header("Cost")]
    public int costPerClick = 1000;

    public GameObject buildUI;
    public GameObject finishCanvas;

    public void BuildSpecificCity(int index)
    {
        for (int i = 0; i < buildings.Length; i++)
        {
            buildings[i].SetActive(false);
        }
        buildings[index].SetActive(true);
        buildUI.SetActive(false);

        CityData.totalCost += costPerClick;

        if (finishCanvas != null)
        {
            finishCanvas.SetActive(true);
        }
    }
}