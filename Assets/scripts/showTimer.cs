using UnityEngine;
using TMPro;

public class ShowTimer : MonoBehaviour
{
    [SerializeField] private Timer timer; // Drag your Timer GameObject here in the Inspector
    private TextMeshProUGUI textMeshPro;

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (timer == null || textMeshPro == null)
        {
            Debug.LogWarning("Timer or TextMeshProUGUI not assigned!");
            return;
        }

        if (timer.Ttime <= 0f)
        {
            textMeshPro.text = "Game Over!";
        }
        else
        {
            textMeshPro.text = timer.Ttime.ToString("F2"); // Show with 2 decimal places
        }
    }
}
