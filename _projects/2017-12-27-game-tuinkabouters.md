---
title: Klunskabouters
subtitle: 'A game about cooperation for the interactive floor platform'
date: 2017-12-27
description: Cooperation game
featured_image: '/images/projects/floor-games/tuinkabouters/game_final.jpg'
exclude: true
---

### Klunskabouters (Clumsy Garden Gnomes)
_Klunskabouters_ is a game about cooperation and our first 3D game on the [interactive floor platform](/project/interactive-floor-project). The game being in 3D posed its own challenges with the way our player detection is setup. 
The goal of the game is for the players to create a chain (by holding hands or standing shoulder to shoulder) to water the flowers in the garden.

![](/images/projects/floor-games/tuinkabouters/game_final.jpg)

The output of our player detection is a list of 2D polygon colliders, representing the player's blobs in top down view. These 2D colliders are aligned facing the Z-axis in Unity, which makes them incompatible with 3D space.
Rewriting the detection to apply in 3D space wasn't possible at this stage and rotating the 3D gameworld 90 degrees facing the 2D camera would make for an interesting time creating levels; For this reason I've chosen to keep the interaction-logic seperate from the visual part of the game. 

With this implementation I have a 2D plane where both player's colliders and the game's colliders are. Interaction happens on this plane, out of the player's view and is communicated to the 3D game world.
Below is a video of the detection in debug view and an indicator at the end of the tracked volume.
<div style="width:100%;height:0px;position:relative;padding-bottom:56.000%;"><iframe src="https://streamable.com/e/tiev3w" frameborder="0" width="100%" height="100%" allowfullscreen style="width:100%;height:100%;position:absolute;left:0px;top:0px;overflow:hidden;"></iframe></div>
The detection input from the Intel Realsense can be seen on the 2D plane where all interaction happens. This is then communicated to the 3D game space which reacts accordingly.

I have setup a grid on both the 2D plane and the gameworld for the designer to align the colliders and flower prefabs on. The levels were actually built using blocks to easily align to the grid with vertex snapping.
The blocks accomodate different flower variants so after building a level the only thing left to do was to switch on the correct flower to use for each block.
Levels are created as prefabs by the designer. Put into a list in the LevelController grouped by difficulty. The code handles the rest! With this setup of levels we can easily add more levels later without any programming needed.

![](/images/projects/floor-games/tuinkabouters/design_to_game.png)

The most interesting development challenge on this game, besides solving the problem of incorporating 2D detection in a 3D game environment, was how to properly detect a chain in the detection data.
We don't want flowers to trigger when there isn't a perfect chain between the watertap and the flower. Our detection doesn't have persistent tracking with player ID's implemented yet, so what I'm working with is simply a list of PolygonColliders that get re-instantiated every frame.  

The way I implemented the _chain detection_ is by checking if the collider hitting the flower is the same collider as the one hitting the water tap. But because the detection is very prone to noise this triggered random connections everywhere.
I expanded my implementation by requiring 3 seperate checks to all run succesfully before registering as a valid connection.
The code snippet below shows the core of the chain detection. It also works with multiple watertaps by looping through them and stopping that loop when a valid connection has been found.
<script src="https://gist.github.com/Rynji/c20d5b88cbfe35ec32914e15823ce831.js" type="text/javascript"></script>

----

[Back to the interactive floor games overview](/project/interactive-floor-games)



