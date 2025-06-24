using UnityEngine;
using System.Collections.Generic;

public class PlayerScore : MonoBehaviour
{
    // Publieke score-variabele, zichtbaar in de Inspector
    public int score = 0;

    // Publieke lijst van verzamelde munten
    public List<int> coins = new List<int>();

    void Start()
    {
        // Toon 3 startberichten
        for (int i = 1; i <= 3; i++)
        {
            Debug.Log("Game gestart! Verzamel munten! (" + i + ")");
        }
    }

    void Update()
    {
        // Check of de speler gewonnen heeft
        if (score >= 50)
        {
            Debug.Log("🎉 Je hebt gewonnen! Totale score: " + score);
        }

        // Druk op spatie om een munt te pakken
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int coinValue = Random.Range(5, 16); // Coin tussen 5 en 15 punten
            AddCoin(coinValue);
        }
    }

    // Functie om een munt toe te voegen
    void AddCoin(int coinValue)
    {
        coins.Add(coinValue);     // Voeg toe aan de lijst
        score += coinValue;       // Verhoog score

        // Toon debugbericht met score en aantal munten
        Debug.Log($"Munt van {coinValue} punten gepakt! Totale score: {score}");
        Debug.Log("Aantal munten verzameld: " + coins.Count);
    }
}
