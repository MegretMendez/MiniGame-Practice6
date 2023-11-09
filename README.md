# MiniGame-Practice6
Project Description: In this project, we the help of managers, gameobjects and other Unity elements, we will create a scene where a Shooter is inclosed in a four wall with floor tiles scenario. Waves of Enemies will spwan and the goal is to eliminate all enemies. There is a catch though. If a player shoots an enemy and instead the bullet hits a wall, a random floor tile will disappear. But wait...there's more!! If the player misses an enemy and the bullet hits a corner window, the entire floor will disappear at the same time. If this happens, you automatically lose. The last obstacle of the game is... simulated rain falling constantly so hitting enemies and moving through the scene will be more difficult.

Step 1: Creating Simulated Rain

Description: Create an Empty GameObject to act as the point from where the raindrops will drop. Inside this Empty Object, create multiple Spheres and add a Wave Manager Script to these new objects. In this case, our point where the spheres will drop and the spheres are called Rain Dropping. We added a Rain Rotation script to the point of drop so that the spheres drop evenly throught the scenario.
