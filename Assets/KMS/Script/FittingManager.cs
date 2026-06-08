using UnityEngine;
using TMPro;

public class FittingManager : MonoBehaviour
{
    public GameObject shirtObject;
    public GameObject pantsObject;

    public Renderer shirtRenderer;
    public Renderer pantsRenderer;

    public Material skyblueMaterial;
    public Material oliveMaterial;

    public TextMeshProUGUI resultText;

    private bool shirtEquipped;
    private bool pantsEquipped;

    void Start()
    {
        shirtObject.SetActive(false);
        pantsObject.SetActive(false);
        resultText.text = "Choose an item to try on.";
    }

    public void TryShirt()
    {
        shirtObject.SetActive(true);
        resultText.text = "Throw the shirt near the body.";
    }

    public void TryPants()
    {
        pantsObject.SetActive(true);
        resultText.text = "Throw the pants near the legs.";
    }

    public void EquipShirt()
    {
        shirtRenderer.material = skyblueMaterial;
        shirtObject.SetActive(false);
        shirtEquipped = true;
        resultText.text = "Shirt equipped.";
    }

    public void EquipPants()
    {
        pantsRenderer.material = oliveMaterial;
        pantsObject.SetActive(false);
        pantsEquipped = true;
        resultText.text = "Pants equipped.";
    }

    public void ShowResult()
    {
        if (shirtEquipped && pantsEquipped)
        {
            resultText.text =
                "Result\n" +
                "Traditional Method : 3 Days -> 3 Minutes\n" +
                "Production Cost : $50 -> $0\n" +
                "Fabric Waste : Generated -> None";
        }
        else
        {
            resultText.text =
                "Please try on both shirt and pants.";
        }
    }
}