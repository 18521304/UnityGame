# 3D Game Description and Features

This is a **3D game** that uses graphic assets sourced from the internet.

## Main Menu
When the game starts, the **main menu** appears with the following options:
- **Play**
- **Option**: Adjust graphics settings.
- **Quit**: Exit the application.

---

## Gameplay
- The game has **3 main stages**, each with different difficulty levels.
- Each stage requires the player to collect **5 main items** to fight monsters.
- A stage is completed when **all monsters on the map are defeated**.
- If the player dies, the stage **resets**.

---

## Controls
### Movement
- **Left Mouse Button**: Click on the terrain to move the character.
- **Walking/Running**:
  - Click a **short distance** to walk slowly.
  - Click a **long distance** to start running.

### Camera
- The camera **follows the character** automatically.
- Drag the mouse to **zoom in/out**.
- Press **A/D** to rotate the camera.

### Interactions
- **Right Mouse Button**:
  - Click on objects to **pick them up**.
  - Click on monsters to **attack them**.

---

## Inventory System
1. **Inventory UI**:
   - Right-click on items on the ground to **pick them up** and add them to the inventory.
   - Items in the inventory can be **equipped**.
2. **Open Inventory**:
   - Press **B** or **I** to open the inventory.
   - Click the **left mouse button** on an item in the inventory to equip it.
3. **Item Arrangement**:
   - Items are arranged **from left to right** in the inventory.
   - Equipped items **shift to the left**.
4. **Unequipping Items**:
   - Press **U** to unequip all equipped items and return them to the inventory.
5. **Deleting Items**:
   - Click the **X icon** on an item in the inventory to delete it.
6. **Interaction Behavior**:
   - **Left-click** outside the menu area to move the character.
   - **Clicking inside the menu area** disables movement.

---

## Character Stats
- **Maximum Health**: 100
- **Default Damage**: 5

### Equipped Items
- **Armor** increases armor stats and reduces damage taken.
- **Weapons** (e.g., swords) increase damage output.
- Equipping items replaces the default clothes with **armor pieces**.
- Unequipping items removes the bonus stats and reverts to **default stats**.

### Taking Damage
- Monsters deal damage to the character.
- Monsters chase the character when within range and stop if the character moves far enough away.
- If the character dies, the **stage resets**.

---

## Combat Mechanics
- Attacks have a **cooldown** to prevent spamming.
- **Health Bar**:
  - Decreases **from right to left** when taking damage.
  - Disappears if no damage is taken for a certain amount of time.

---

## Scoring System
- Points are awarded for **defeating monsters**.
- If the player dies during a stage:
  - **All points earned in that stage are lost**.
  - An additional **10 points are deducted** as a death penalty.

---

## Pause Menu
Press **Esc** to pause the game. The pause menu includes:
- **Resume**: Continue playing.
- **Main Menu**: Return to the main menu.
- **Option**: Adjust game settings.
- **Quit**: Exit the application.

---

## Issues and To-Do List
1. Design a **better UI** (optional).
2. Add an **end-game UI**.
3. Add a **"How to Play"** button.
4. Implement a **save & load** feature.
5. Add a **storyline** (optional).
6. Implement **audio effects** (done).
7. Complete **stage designs** (done?).
8. Improve the **inventory UI**.
9. Add a **high score** system.
10. Add **equipment functionality**.
11. Add a **naming system** for characters or items.
