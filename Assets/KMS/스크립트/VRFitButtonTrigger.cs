using UnityEngine;

public class VRFitButtonTrigger : MonoBehaviour
{
    public FittingManager manager;
    public string buttonType;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Controller")) return;

        if (buttonType == "Shirt") manager.TryShirt();
        if (buttonType == "Pants") manager.TryPants();
        if (buttonType == "Result") manager.ShowResult();
    }
}