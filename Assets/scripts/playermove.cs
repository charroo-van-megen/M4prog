using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    public ScoreCount scoreCount; // Verwijzing naar ScoreCount-script (sleep in Inspector)

    void Start()
    {
        Debug.Log("Snelheid ingesteld op: " + speed);
        
        // Controleer of de ScoreCount is gekoppeld
        if (scoreCount == null)
        {
            Debug.LogError("ScoreCount is NIET gekoppeld aan PlayerMove. Sleep het object met ScoreCount in de Inspector!");
        }
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h, 0, v) * speed * Time.deltaTime;
        transform.Translate(move);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            if (scoreCount != null)
            {
                scoreCount.AddScore(10); // Voeg score toe
                Debug.Log("Munt opgepakt!");
            }
            else
            {
                Debug.LogError("ScoreCount is niet gekoppeld!");
            }

            Destroy(other.gameObject); // Verwijder munt uit scene
        }
    }
}
