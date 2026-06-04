using UnityEngine;
using TMPro;

public class GoalTriggerScript : MonoBehaviour
{
    public GameObject goalText;

    void OnTriggerEnter(Collider other)
    {
        goalText.SetActive(true);
    }
}
