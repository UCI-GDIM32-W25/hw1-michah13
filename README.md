[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

### Breakdown

#### Objects
- Player
- Plant
- UI
- Seeds Planted UI
- Seeds Remaining UI
- Camera
#### Attributes / Actions
- The player
    - The player can move in eight directions with the WASD keys.
    - The player can move freely through the world’s borders.
- The plant
    - One is planted each time the player presses SPACE.
    - The plants have no collision, so the player can walk through them.
- Seeds Planted UI
    - Shows the number of plants planted.
    - Begins at 0.
- Seeds Remaining UI
    - Shows the number of available plants.
    -    Begins at 5.
#### Interactions
- Press SPACE to create a plant at the player’s current location.
- The seeds planted UI increases each time a plant is planted.
- The seeds remaining UI decreases each time a plant is planted.
- Once the seeds remaining Ui reaches zero, the player can no longer plant anymore plants, and no more plants can appear.

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


I used my breakdown as a blueprint for what to add before checking the rubric to see more specific instructions and double-check if i missed something. The simplified correlate very clearly to GameObjects: the player is `Player`, the plant is `Plant`, the camera is `Camera`, and the two UI objects are `Text_SeedsPlanted` and `Text_SeedsRemaining` (although, for those, the number and text are two seperate objects, bringing the total to four.)

The player's movement is handled by the player script's `Update()` in line 24, where the player's transform is translated by `Input.GetAxis`. The ability to move through walls and plants is by default, since it only requires a *lack* of collisions to function.

Seed planting also happens in the player's script, in lines 25-31. If the spacebar is pressed or held, the game checks once if `_numSeedsLeft` is greater than 0. If it is, `PlantSeed()` is called. In order, this method: clones the plant prefab at the player's position, subtracts `_numSeedsLeft`, adds to `_numSeedsPlanted`, and updates the UI accordingly.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
