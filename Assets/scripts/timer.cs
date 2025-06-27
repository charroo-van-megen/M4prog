using UnityEngine;

public class Timer : MonoBehaviour
{
    public float Ttime = 10f; // Starting time in seconds

    void Update()
    {
        if (Ttime > 0f)
        {
            Ttime -= Time.deltaTime;
        }
        else
        {
            Ttime = 0f; // Clamp to zero
        }
    }
}
