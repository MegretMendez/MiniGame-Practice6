# MiniGame-Practice6

By: David Mendez & Jose Megret

Project Description: In this project, we use the help of managers, gameobjects and other Unity elements, in which we will create a scene where a Shooter is inclosed in a four wall with floor tiles scenario. Waves of Enemies will spawn and the goal is to eliminate all enemies. 

***There is a catch though.***
- If a player shoots an enemy and instead the bullet hits a wall, a random floor tile will disappear.
  
***But wait...there's more!!***
- If the player misses an enemy and the bullet hits a corner window, the entire floor will disappear at the same time. If this happens, **you automatically lose**.
  
***The last obstacle of the game is...***
- Simulated rain falling constantly so hitting enemies and moving through the scene will be more difficult.


***Step by Step guide of game creation:***

Step 1: Creating Simulated Rain
![Screenshot 2023-11-08 at 9 02 00 PM](https://github.com/MegretMendez/MiniGame-Practice6/assets/142510070/559ffad0-1d9c-42ec-a843-96c7fb6c5610)

Description: Create an Empty GameObject to act as the point from where the raindrops will drop. Inside this Empty Object, create multiple Spheres and add a Wave Spawn Script to these new objects. In this case, our point where the spheres will drop and the spheres are called Rain Dropping. We added a Rain Rotation script to the point of drop so that the spheres drop evenly throught the scenario.

Scripts used in Step 1:
Rain Rotation:
![Screenshot 2023-11-08 at 9 07 01 PM](https://github.com/MegretMendez/MiniGame-Practice6/assets/142510070/cc74d8ea-2052-4bfb-b6ce-6c509419f191)

WaveSpawner:
![Screenshot 2023-11-08 at 9 12 40 PM](https://github.com/MegretMendez/MiniGame-Practice6/assets/142510070/15bd4c30-7420-4500-a3ff-229e7d709069)
![Screenshot 2023-11-08 at 9 13 23 PM](https://github.com/MegretMendez/MiniGame-Practice6/assets/142510070/a6db218b-4776-4c37-ac44-1f1f94e9d2cf)

Rain Droping:
https://drive.google.com/file/d/1GInwgqSjTpO1114ekctUr6B_bkHKFzU_/view?usp=sharing

Step 2: Enemy Waves
![Screenshot 2023-11-08 at 9 42 44 PM](https://github.com/MegretMendez/MiniGame-Practice6/assets/142510070/c577d0e8-d6d6-4082-ba3d-2f8b29f14e7a)

Description: Enemies will spawn from 4 different points, in this case from every corner. Therefore we will creat 4 Empty Objects and position each one on a corner of the map. To each object add a Script called WaveSpawn. There will also be a Wave Manager that is in charge of these spawn points. The script Wave Spawn is th same script from Step 1. 

Enemy Manager Script:
![Screenshot 2023-11-08 at 9 41 26 PM](https://github.com/MegretMendez/MiniGame-Practice6/assets/142510070/907bdd9e-149f-4cc3-b810-7a2209fd5e7b)


Step 4: Floors

![Screenshot 2023-11-08 at 9 55 43 PM](https://github.com/MegretMendez/MiniGame-Practice6/assets/142510070/25eba844-608d-49b5-83c2-57c93bb16206)

Description: Every Floor panel will have a Box Collider and a Script called Floors, which is commented for better and easier understanding. In addition, a floorManager will be encharge of adding and removing floors from a list when called.

FloorManager Script:
![Screenshot 2023-11-08 at 10 03 36 PM](https://github.com/MegretMendez/MiniGame-Practice6/assets/142510070/179a26af-2fdd-42f5-b034-e3d2b220a721)
![Screenshot 2023-11-08 at 10 04 41 PM](https://github.com/MegretMendez/MiniGame-Practice6/assets/142510070/bafcfd79-fad7-42af-9162-225039f9fbe6)

Result:
https://drive.google.com/file/d/1tMcrSFiwH5lSGYua2MCrUZvAKMlI6PMT/view?usp=sharing
