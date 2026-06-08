using UnityEngine;

public class CutPoint : MonoBehaviour
{
    public int pointNumber;
    public CuttingManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Scissors"))
        {
            manager.CheckPoint(pointNumber);
            gameObject.SetActive(false);
        }
    }
}