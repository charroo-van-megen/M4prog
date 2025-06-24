using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    // Prefab om te spawnen, via inspector toewijzen
    public GameObject enemyPrefab;

    // Startpositie voor de eerste enemy (bijv. de positie van dit object)
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        StartCoroutine(SpawnWave());
    }

    // Coroutine om golven te spawnen
    IEnumerator SpawnWave()
    {
        // Loop 5 keer (vijand nummer 0 t/m 4)
        for (int i = 0; i < 5; i++)
        {
            // Wacht 2 seconden voor elke spawn
            yield return new WaitForSeconds(2f);

            // Bereken spawnpositie: startPos + (i * 2) naar rechts
            Vector3 pos = startPosition + Vector3.right * i * 2f;

            // Instantiate enemyPrefab op positie pos, zonder rotatie
            Instantiate(enemyPrefab, pos, Quaternion.identity);

            // Debug log welk nummer vijand gespawned is
            Debug.Log("Vijand gespawned: " + i);
        }
    }
}
