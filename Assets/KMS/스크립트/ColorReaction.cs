using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ColorReaction : MonoBehaviour
{
    public TMP_Text resultText;
    public Image resultPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("SkyBlue"))
        {
            resultText.text = "Sky Blue\nBest match for your skin tone\nScore: 5/5";
            resultPanel.color = new Color32(80, 170, 210, 130);
        }
        else if (other.name.Contains("Lavender"))
        {
            resultText.text = "Lavender\nBright and fresh look\nScore: 4/5";
            resultPanel.color = new Color32(190, 150, 210, 130);
        }
        else if (other.name.Contains("Coral"))
        {
            resultText.text = "Coral\nNatural and balanced\nScore: 3/5";
            resultPanel.color = new Color32(255, 120, 80, 130);
        }
        else if (other.name.Contains("SoftPink"))
        {
            resultText.text = "Soft Pink\nSoft and gentle match\nScore: 3/5";
            resultPanel.color = new Color32(240, 150, 180, 130);
        }
        else if (other.name.Contains("Olive"))
        {
            resultText.text = "Olive\nMay make skin look dull\nScore: 2/5";
            resultPanel.color = new Color32(110, 120, 40, 130);
        }
        else if (other.name.Contains("Mint"))
        {
            resultText.text = "Mint\nMay darken facial tone\nScore: 1/5";
            resultPanel.color = new Color32(90, 200, 150, 130);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        resultText.text = "Bring the fabric close to the face";
        resultPanel.color = new Color32(20, 20, 20, 100);
    }
}