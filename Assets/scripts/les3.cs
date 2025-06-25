
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Publieke variabelen voor snelheid en tijd, zichtbaar in de Inspector
    public float speed = 5f;
    public float timeLeft = 20f;

    // Private score teller
    private int score = 0;

    // Referentie naar Rigidbody
    private Rigidbody rb;

    // Of het spel nog bezig is
    private bool gameActive = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Verzamel de munten voordat de tijd op is!");
    }

    void Update()
    {
        // Beweeg speler met pijltjestoetsen
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ) * speed;
        rb.linearVelocity = new Vector3(move.x, rb.linearVelocity.y, move.z); // behoud verticale snelheid (bijv. zwaartekracht)

        // Timer aftellen
        if (gameActive)
        {
            timeLeft -= Time.deltaTime;
            Debug.Log("Tijd over: " + Mathf.Ceil(timeLeft) + "s | Score: " + score);

            if (timeLeft <= 0)
            {
                gameActive = false;
                timeLeft = 0;
                Debug.Log("Game Over! Je score: " + score);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check of het object de tag "Coin" heeft
        if (other.CompareTag("Coin") && gameActive)
        {
            score += 10;
            Debug.Log("Munt gepakt! Score: " + score);

            Destroy(other.gameObject);
        }
    }
}
