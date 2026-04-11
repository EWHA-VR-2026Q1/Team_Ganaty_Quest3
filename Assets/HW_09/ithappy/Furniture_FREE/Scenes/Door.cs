using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [SerializeField] private string targetSceneName;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(targetSceneName);
    }
}
