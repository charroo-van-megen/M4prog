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

 

# Opdracht 2: Bewegende Speler

## 🎯 Omschrijving
In deze opdracht heb ik een eenvoudige speler gemaakt die kan **bewegen** met de pijltjestoetsen en **springen** met de spatiebalk. Ik heb gebruik gemaakt van een Rigidbody voor physics, en input met `Input.GetAxis()` en `Input.GetKeyDown()`.

## 💻 Functionaliteiten
- Beweging in 2D-vlak met pijltjestoetsen of WASD
- Springen als de speler op de grond staat
- Debug-log die springactie laat zien in de console
- Variabelen `moveSpeed` en `jumpForce` instelbaar in Inspector

## 🎥 Demonstratie
![Gameplay](https://github.com/jouwgebruikersnaam/opdracht-bewegende-speler/blob/main/demo/jump-move.gif)

## 🔗 Script
- [`PlayerControl.cs`](Assets/scripts/les2.cs)

## 📌 Setup-instructies
1. Maak een **cube** en noem deze `Player`.
2. Voeg een **Rigidbody** toe aan de speler.
3. Voeg dit script toe aan de speler.
4. Voeg een **Plane** toe als vloer, en tag deze met `"Ground"`.
5. Speel de scène af en beweeg met toetsen.

## 🛠️ Projectstructuur



# Opdracht 3: Timed Muntjacht 🎮

## 📌 Omschrijving
In deze opdracht heb ik een simpele muntverzamelgame gebouwd in Unity. De speler beweegt met de pijltjestoetsen, verzamelt munten, en moet dat doen binnen een **tijdslimiet van 20 seconden**. De score en timer worden in de console weergegeven.

## 🧠 Wat ik geleerd heb
- Bewegen met `Vector3` en `Time.deltaTime`
- Detecteren van triggers met `OnTriggerEnter`
- Timer maken met `Time.deltaTime`
- Variabelen publiek maken voor testing in Inspector

## 🖥️ Functionaliteit
- Speler beweegt met pijltjestoetsen
- Score stijgt bij het verzamelen van munten
- Timer telt af vanaf 20 seconden
- "Game Over" verschijnt in de console wanneer tijd op is

## 🔗 Script
- [`GameManager.cs`](Assets/scripts/les3.cs)

## 🎥 Demonstratie
![Gameplay](https://github.com/jouwgebruikersnaam/timed-muntjacht/blob/main/demo/muntjacht.gif)

## ⚙️ Setup-instructies
1. Voeg een `Cube` toe als speler en een `Plane` als vloer.
2. Voeg aan de speler een `Rigidbody` toe.
3. Voeg 2–3 `Cube` munten toe en zet hun Collider op "Is Trigger".
4. Geef alle munten de tag `"Coin"`.
5. Voeg `GameManager.cs` toe aan de speler.

## 🛠️ Inspector-waarden
```plaintext
speed = 5
timeLeft = 20

 
 
 
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


