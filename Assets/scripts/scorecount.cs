using UnityEngine;
using TMPro; // Voor TextMeshPro

public class ScoreCount : MonoBehaviour
{
    public TMP_Text scoreText; // Verwijzing naar de TextMeshPro UI
    private int score = 0;

    void Start()
    {
        UpdateScoreText(); // Startscore tonen
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
