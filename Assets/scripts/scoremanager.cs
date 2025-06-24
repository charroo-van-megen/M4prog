using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Zorg voor een variabele met je startscore
    public int score = 0;

    // Maak een methode AddScore die vanaf een ander script aangeroepen kan worden
    public void AddScore(int punten)
    {
        // Tel de punten op bij de score
        score += punten;

        // Stuur bericht naar de console dat je een munt hebt gepakt!
        Debug.Log("Munt gepakt! Score is nu: " + score);
    }
}

