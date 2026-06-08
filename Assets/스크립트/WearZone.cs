using UnityEngine;

public class WearZone : MonoBehaviour
{
    public FittingManager manager;
    public string targetTag;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(targetTag)) return;

        if (targetTag == "shirt") manager.EquipShirt();
        if (targetTag == "pants") manager.EquipPants();
    }
}