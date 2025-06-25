using UnityEngine;

public class FollowAndReturn : MonoBehaviour
{
    public Transform player;      // Verwijzing naar de speler
    public float followSpeed = 2f;
    public float returnSpeed = 3f;
    public float reachDistance = 0.5f;  // Afstand waarop volger dicht genoeg bij speler is

    private Vector3 startPosition;
    private bool returning = false;

    void Start()
    {
        startPosition = transform.position;  // Onthoud startpositie van volger
    }

    void Update()
    {
        if (!returning)
        {
            // Volg de speler met Vector3.Lerp voor soepele beweging
            transform.position = Vector3.Lerp(transform.position, player.position, followSpeed * Time.deltaTime);

            // Meet afstand tot speler
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            // Als dichtbij genoeg, begin terug te gaan
            if (distanceToPlayer < reachDistance)
            {
                returning = true;
            }
        }
        else
        {
            // Beweeg met constante snelheid terug naar startpositie
            Vector3 direction = (startPosition - transform.position).normalized;
            transform.position += direction * returnSpeed * Time.deltaTime;

            // Meet afstand tot startpositie
            float distanceToStart = Vector3.Distance(transform.position, startPosition);

            // Als bijna bij startpositie, stop met teruggaan
            if (distanceToStart < 0.1f)
            {
                returning = false;
            }
        }
    }
}
