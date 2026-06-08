using UnityEngine;

public class DayNightManager : MonoBehaviour
{
    public Light sun;

    public void SetDay()
    {
        Debug.Log("DAY BUTTON");
        sun.intensity = 1.2f;
        sun.color = Color.white;
    }

    public void SetNight()
    {
        Debug.Log("NIGHT BUTTON");
        sun.intensity = 0.1f;
        sun.color = new Color(0.5f, 0.6f, 1f);
    }
    
}