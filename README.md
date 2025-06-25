# M4PROG
 # Opdracht 8: Vijandgolf

## 🎯 Omschrijving
In deze opdracht heb ik een vijand-golf systeem gebouwd in Unity. Het systeem gebruikt coroutines om vijanden (cubes) te spawnen vanaf een spawnpunt met 2 seconden tussen elke spawn. Na de eerste golf volgt een tweede golf 5 seconden later, die direct achter de eerste rij gespawned wordt.

## 📷 Demonstratie
![Vijandgolf Demo](https://github.com/jouwgebruikersnaam/opdracht8-vijandgolf/blob/main/demo/vijandgolf.gif)

## ⚙️ Features
- Spawnt 5 vijanden per golf
- 2 seconden wachttijd tussen vijanden
- Tweede golf na 5 seconden, netjes achter de eerste rij
- Gebruik van `Coroutine` en `WaitForSeconds`

## 🔗 Scripts

- [`SpawnManager.cs`](https://github.com/jouwgebruikersnaam/opdracht8-vijandgolf/blob/main/Assets/Scripts/SpawnManager.cs)

## 🧱 Gebruikte Objecten

| Object       | Componenten                             | Script             |
|--------------|------------------------------------------|--------------------|
| SpawnPoint   | Transform (leeg GameObject)              | SpawnManager.cs    |
| EnemyPrefab  | Cube + BoxCollider + Rigidbody (kinematic)| *geen script nodig* |

## 🧠 Lessen geleerd
- Hoe je `IEnumerator` en `yield return` gebruikt
- Werken met prefab instantiatie via `Instantiate`
- Afstanden en positionele berekening met `Vector3`

## 📁 Bestandsstructuur


