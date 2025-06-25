# M4PROG
# Opdracht 1: Score en Munten

## 🎯 Omschrijving
In deze opdracht heb ik een simpel score-systeem gemaakt in Unity met C#. De speler (cube) verzamelt munten door op de spatiebalk te drukken. Elke munt levert 10 punten op. Als je 50 punten of meer hebt, win je het spel.

## 💻 Functionaliteiten
- Houdt score bij
- Gebruikt `if`-statement voor winconditie
- Loopt bij Start 3 keer een welkomsbericht
- Gebruikt een `List<string>` om verzamelde munten bij te houden
- Functie `AddCoin` voegt een munt toe aan de lijst

## 🎥 Demonstratie
![Gameplay Gif](https://github.com/jouwgebruikersnaam/score-munten-unity/blob/main/demo/score-munten.gif)

## 🔗 Script
[Assets/scripts/coin.cs](Assets/scripts/coin.cs)

## 📌 Instructies
- Druk op `Spatie` om een munt toe te voegen.
- Bij 50 punten verschijnt "Je hebt gewonnen!" in de console.
- Bekijk `score` en `coins` live in de Unity Inspector.

## 📁 Bestandsstructuur

 
 
 
 
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

- [Assets/scripts/les8.cs](Assets/scripts/les8.cs)

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


