using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GoToScene2()
    {
        SceneManager.LoadScene("Scene02_Cutting");
    }

    public void GoToScene3()
    {
        SceneManager.LoadScene("Scene03_Fitting");
    }

    public void GoToScene1()
    {
        SceneManager.LoadScene("Scene01_PersonalColor");
    }
}