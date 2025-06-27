# M4PROG
🟢 Opdracht 1: Score en Munten
🎯 Speler verzamelt munten met spatiebalk, elke munt is 10 punten. Bij 50 punten: winst.
🔗 [coin.cs](Assets/scripts/coin.cs)
🎥
![ezgif com-video-to-gif-converter (1)](https://github.com/user-attachments/assets/ea06383d-9516-4321-b892-62510a2ea2a0)

🟠 Opdracht 2: Bewegende Speler
🎯 Speler beweegt met pijltjestoetsen, springt met spatie, gebruikt Rigidbody en input.
🔗 [PlayerControl.cs](Assets/scripts/les2.cs)
🎥
![ezgif com-video-to-gif-converter (1)](https://github.com/user-attachments/assets/98d4d3ca-8c18-4694-a677-052c3a2d7dc9)

🟡 Opdracht 3: Timed Muntjacht
🎯 Speler verzamelt munten binnen 20 seconden. Score en timer in console.
🔗 [GameManager.cs](Assets/scripts/les3.cs)
🎥
![ezgif com-video-to-gif-converter (1)](https://github.com/user-attachments/assets/0cee16be-b1dd-44c7-996a-a685f2c1704d)

🔵 Opdracht 4: Start en Spel
🎯 Twee scènes: start en game. Druk spatie om te wisselen. Speler beweegt, munten spawnen.
🔗 [SceneSwitcher.cs](Assets/scripts/scenemanager.cs)
🔗 [PlayerControl.cs](Assets/scripts/les2.cs)
🔗 [CoinSpawner.cs](Assets/scripts/les8.cs)
🎥![ezgif com-video-to-gif-converter (2)](https://github.com/user-attachments/assets/f4615e5c-a8cd-4dda-8a49-61596d32db5b)


🟣 Opdracht 5: Gestructureerde Muntjager
🎯 Speler beweegt en verzamelt munten. Score wordt beheerd via apart script met debug-output.
🔗 [PlayerMove.cs](Assets/scripts/playermove.cs)
🔗 [ScoreManager.cs](Assets/scripts/scoremanager.cs)
🎥[ezgif com-video-to-gif-converter (3)](https://github.com/user-attachments/assets/5b98d3aa-8af5-4882-b3f0-1d72ca602c4e)

🧲 Opdracht 6: Volger
🎯 Sphere volgt de speler met Lerp, keert terug met vaste snelheid. Afstand en richting worden gemeten met Vector3.Distance en normalized.

🔗 [PlayerMove.cs](Assets/scripts/playermove.cs)
🔗 [FollowAndReturn.cs](Assets/scripts/les6.cs)
🎥![ezgif com-video-to-gif-converter (5)](https://github.com/user-attachments/assets/7bb46f36-637a-48f7-90e0-d3347119a66c)


🏆 Opdracht 7: Muntenscore met TMP
Doel: Score wordt getoond in UI met TextMeshPro en stijgt bij het verzamelen van munten.

Scripts
[ScoreManager.cs](Assets/scripts/scoremanager.cs)
[PlayerMove.cs](Assets/scripts/playermove.cs)
[Demonstratie]![ezgif com-video-to-gif-converter (3)](https://github.com/user-attachments/assets/5b98d3aa-8af5-4882-b3f0-1d72ca602c4e)



🔴 Opdracht 8: Vijandgolf
🎯 Vijanden spawnen in twee golven met tussenpauze, via Coroutine en Instantiate.
🔗 [SpawnManager.cs](Assets/scripts/les8.cs)
🎥![ezgif com-video-to-gif-converter (4)](https://github.com/user-attachments/assets/f6a31d1a-3b56-46bb-98b6-95580c240d64)


# ⏱ Unity Countdown Timer

A simple countdown timer using `Time.deltaTime` and `TextMeshProUGUI`. Displays remaining time and shows "Game Over" when the timer hits zero.

---[timer]

## 🎥 Demo

![Demo](path/to/demo.gif)  
![ezgif com-video-to-gif-converter (6)](https://github.com/user-attachments/assets/f7c6d95f-a3c1-447a-82de-4a436f4b98b0)

## 🚶 Patrolling Setup

This script makes a GameObject (e.g. an enemy or player) move between three points: A → B → C → B → A, continuously.

### 🛠 Scene Setup

1. **Create 3 empty GameObjects** in your scene:
   - Rename them to `PointA`, `PointB`, and `PointC`
   - Position them where you want the patrol path to go

2. **Create or select a GameObject** to patrol (e.g., a cube or character)
   - Rename it `Player` (or anything — you'll drag it in later)

3. **Create an empty GameObject** and attach the `Patrolling.cs` script to it.

4. **Assign references** in the Inspector:
   - `Point A` → drag in `PointA`
   - `Point B` → drag in `PointB`
   - `Point C` → drag in `PointC`
   - `Player` → drag in the object to patrol
   - `Speed` → set a value (e.g., `2`)

5. **Hit Play** — the player moves between the points in a ping-pong pattern.
![ezgif com-video-to-gif-converter (7)](https://github.com/user-attachments/assets/9ce9a784-a382-45b1-a74d-c3dd4c3357b2)

   



