using UnityEngine;
using TMPro;

public class CuttingManager : MonoBehaviour
{
    public int currentPoint = 1;

    public TextMeshProUGUI resultText;

    public GameObject skyBlueFabric;
    public GameObject oliveFabric;

    public GameObject shirtPattern;
    public GameObject pantsPattern;

    public GameObject[] cutPoints;

    private bool shirtSelected = false;
    private bool pantsSelected = false;

    void Start()
    {
        skyBlueFabric.SetActive(false);
        oliveFabric.SetActive(false);

        shirtPattern.SetActive(false);
        pantsPattern.SetActive(false);

        SetCutPoints(false);

        resultText.text =
            "Choose a pattern\n" +
            "Shirt or Pants";
    }

    void SetCutPoints(bool value)
    {
        foreach (GameObject point in cutPoints)
        {
            point.SetActive(value);
        }
    }

    public void ShowShirt()
    {
        shirtSelected = true;
        pantsSelected = false;

        currentPoint = 1;

        skyBlueFabric.SetActive(true);
        oliveFabric.SetActive(false);

        shirtPattern.SetActive(false);
        pantsPattern.SetActive(false);

        SetCutPoints(true);

        resultText.text =
            "Shirt Pattern Selected!\n" +
            "Proceed to fabric cutting.";
    }

    public void ShowPants()
    {
        shirtSelected = false;
        pantsSelected = true;

        currentPoint = 1;

        skyBlueFabric.SetActive(false);
        oliveFabric.SetActive(true);

        shirtPattern.SetActive(false);
        pantsPattern.SetActive(false);

        SetCutPoints(true);

        resultText.text =
            "Pants Pattern Selected!\n" +
            "Proceed to fabric cutting.";
    }

    public void CheckPoint(int point)
    {
        if (point == currentPoint)
        {
            currentPoint++;

            if (currentPoint > 5)
            {
                SetCutPoints(false);

                skyBlueFabric.SetActive(false);
                oliveFabric.SetActive(false);

                if (shirtSelected)
                {
                    shirtPattern.SetActive(true);
                }

                if (pantsSelected)
                {
                    pantsPattern.SetActive(true);
                }

                resultText.text =
                    "Cutting Complete!\n" +
                    "No fabric waste generated.\n" +
                    "Estimated Time Saved : 3 Days\n" +
                    "Estimated Cost Savings : $50";
            }
        }
    }

    public void UndoCutting()
    {
        currentPoint = 1;

        shirtSelected = false;
        pantsSelected = false;

        skyBlueFabric.SetActive(false);
        oliveFabric.SetActive(false);

        shirtPattern.SetActive(false);
        pantsPattern.SetActive(false);

        SetCutPoints(false);

        resultText.text =
            "Choose a pattern\n" +
            "Shirt or Pants";
    }
}