using UnityEngine;
using System.Collections.Generic;

public class PlayerScore : MonoBehaviour
{
    // Private Variabele voor score type int
    private int score;

    // Private List voor "Coins" type int
    private List<int> coins;

    void Start()
    {
        score = 0;
        coins = new List<int>();

        // Loop: toon 3x een startbericht met Debug.Log in een loop
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("Game gestart! Verzamel munten!");
        }
    }

    void Update()
    {
        // If-statement: check of score >= 50
        // Zo ja geef een bericht met Debug.Log dat je hebt gewonnen
        if (score >= 50)
        {
            Debug.Log("Je hebt gewonnen!");
        }

        // Test: druk op spatie om een munt toe te voegen
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Roep functie AddCoin aan en geef de waarde van de coin mee
            // Gebruik Random.Range(int min, int max) om een random waarde aan je coin te geven
            int coinValue = Random.Range(5, 16); // willekeurige waarde tussen 5 en 15
            AddCoin(coinValue);
        }
    }

    // Functie om een munt toe te voegen
    void AddCoin(int coinValue)
    {
        // Voeg munt toe aan lijst
        coins.Add(coinValue);

        // Verhoog score met de coin value
        score += coinValue;

        // Geef bericht dat je een coin hebt gepakt en toon je nieuwe score
        Debug.Log($"Je hebt een munt van {coinValue} punten gepakt! Totale score: {score}");
    }
}
