using UnityEngine;

public class ScissorTrigger : MonoBehaviour
{
    public CuttingManager manager;

    private void OnTriggerEnter(Collider other)
    {
        CutPoint point = other.GetComponent<CutPoint>();

        if (point != null)
        {
            manager.CheckPoint(point.pointNumber);
        }
    }
}