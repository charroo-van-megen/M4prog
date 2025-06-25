# M4PROG
🟢 Opdracht 1: Score en Munten
🎯 Speler verzamelt munten met spatiebalk, elke munt is 10 punten. Bij 50 punten: winst.
🔗 [coin.cs](Assets/scripts/coin.cs)
🎥

🟠 Opdracht 2: Bewegende Speler
🎯 Speler beweegt met pijltjestoetsen, springt met spatie, gebruikt Rigidbody en input.
🔗 [PlayerControl.cs](Assets/scripts/les2.cs)
🎥

🟡 Opdracht 3: Timed Muntjacht
🎯 Speler verzamelt munten binnen 20 seconden. Score en timer in console.
🔗 [GameManager.cs](Assets/scripts/les3.cs)
🎥

🔵 Opdracht 4: Start en Spel
🎯 Twee scènes: start en game. Druk spatie om te wisselen. Speler beweegt, munten spawnen.
🔗 [SceneSwitcher.cs](Assets/scripts/scenemanager.cs)
🔗 [PlayerControl.cs](Assets/scripts/les2.cs)
🔗 [CoinSpawner.cs](Assets/scripts/les8.cs)
🎥

🟣 Opdracht 5: Gestructureerde Muntjager
🎯 Speler beweegt en verzamelt munten. Score wordt beheerd via apart script met debug-output.
🔗 [PlayerMove.cs](Assets/scripts/playermove.cs)
🔗 [ScoreManager.cs](Assets/scripts/scoremanager.cs)
🎥

🧲 Opdracht 6: Volger
🎯 Sphere volgt de speler met Lerp, keert terug met vaste snelheid. Afstand en richting worden gemeten met Vector3.Distance en normalized.

🔗 [PlayerMove.cs](Assets/scripts/playermove.cs)
🔗 [FollowAndReturn.cs](Assets/scripts/les6.cs)
🎥

🏆 Opdracht 7: Muntenscore met TMP
Doel: Score wordt getoond in UI met TextMeshPro en stijgt bij het verzamelen van munten.

Scripts
[ScoreManager.cs](Assets/scripts/scoremanager.cs)
[PlayerMove.cs](Assets/scripts/playermove.cs)
[Demonstratie]


🔴 Opdracht 8: Vijandgolf
🎯 Vijanden spawnen in twee golven met tussenpauze, via Coroutine en Instantiate.
🔗 [SpawnManager.cs](Assets/scripts/les8.cs)
🎥
