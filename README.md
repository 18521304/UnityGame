This is a 3D game that uses graphic assets sourced from the internet.
When the game starts, the main menu appears, which includes the following options:

  Play
  Option: Adjust graphics settings.
  Quit: Exit the application.

Gameplay:

  The game has 3 main stages, and each stage has a different level of difficulty.
  In each stage, the player needs to collect 5 main items to fight monsters.
  The stage is considered complete when all monsters on the map are defeated.
  If the player dies, the stage resets.

Controls:

  Movement: Click the left mouse button on the terrain to move the character.
    Camera:
        The camera follows the character automatically.
        Drag the mouse to zoom in/out.
        Press the A/D keys to rotate the camera.
    Interactions:
        Right-click on objects to pick them up.
        Right-click on monsters to attack them.
    Walking/Running:
        Click a short distance to walk slowly.
        Click a long distance to start running.

Inventory System:

  Inventory UI:
        When you right-click on items on the ground, the character picks up the items and adds them to the inventory.
        From the inventory, items can be equipped.
  Open Inventory:
        Press B or I to open the inventory.
        Click the left mouse button on an item in the inventory to equip it.
  Item Arrangement:
        Items in the inventory are arranged from left to right.
        When equipped, the items are shifted to the left.
  Unequipping Items:
        Press U to unequip all currently equipped items and return them to the inventory.
  Deleting Items:
        Click the X icon on an item in the inventory to delete it.
  Interaction Behavior:
        The player can move normally by left-clicking outside the menu area.
        If the player clicks inside the menu area, the character cannot move.

Character Stats:

  The character has its own stats:
        Max health: 100.
        Default damage: 5.
  Equipped Items:
        When equipped, items provide increased armor and reduced damage taken.
        Equipping armor replaces the character’s default clothes with armor pieces.
        Armor and pants increase armor stats, while weapons (like swords) increase damage output.
        If unequipped, the additional stats disappear, returning the character to its default stats.
  Taking Damage:
        Monsters deal damage to the character.
        When the character approaches a certain range, monsters will chase the character.
        If the character moves far enough away, the monsters will stop chasing.
        When the character takes damage and dies, the stage will reset.

Combat Mechanics:

  There is a cooldown for each attack to prevent spamming.
  Both the player and the monsters have a health bar:
        The health bar decreases from right to left when taking damage.
        The health bar disappears if the character does not take damage for a certain period of time.

Scoring System:

  Points are awarded based on the number of monsters defeated.
  If the player dies during a stage:
        When the stage reloads, all points earned during that stage are lost.
        Additionally, 10 points are deducted as a death penalty.

Pause Menu:

   Press Esc to pause the game.
  The pause menu includes the following options:
        Resume: Continue playing.
        Main Menu: Return to the main menu.
        Option: Adjust game settings.
        Quit: Exit the application.

Issues and To-Do List:

  Design a better UI (optional).
  Add an end-game UI.
  Add a "How to Play" button.
  Implement a save & load feature.
  Add a storyline (optional).
  Implement audio effects (done).
  Complete stage designs (done?).
  Improve the inventory UI.
  Add a high score system.
  Add equipment functionality.
  Add a naming system for characters or items.
