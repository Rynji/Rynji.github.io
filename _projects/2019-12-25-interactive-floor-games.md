---
title: 'Interactive Floor Games'
subtitle: 'Highlights from the development of the games I worked on'
date: 2019-12-25
description: Multiple games I developed have released on the Interactive Floor platform the past 2 years. These are some development highlights.
featured_image: '/images/projects/floor-games/floor-games_tile.jpg'
---

Below are my personal highlights of the development of the games I've worked on at [Springlab](https://springlab.nl).
All games are played on the [Interactive Floor Platform](/project/interactive-floor-project). Five games have released so far and the sixth is under development.  
Usually, one game designer leads a _game project_ and each game has one game developer (we have 2 of both). The game designer draws out the game using a screen flow; this screen flow is the base which the developers work from.  
I always work closely together with those involved, iterating on implementations to make sure the end result is up to our standards.

----

### Reuzentranen (Giant's Tears)
This game is built using entirely 2D assets but using a perspective view. Making the gameworld a believable, traversable space. 
_Reuzentranen_ is designed to be an interactive, linear story telling game. Players follow the main-character through a series of events.

The game starts with an introduction sequence where the camera zooms in through a layer of leaves. I used a sprite shader which writes to the depth buffer so I could apply a depth of field post process effect.
This depth of field effect is used throughout the game. 

![](/images/projects/floor-games/reusgame/reus_00intro_collage.jpg)

The next sequence has the players jump from leaf to leaf to reach the next dry 'land'. Leaves stop when stepped on to help the players cross.  
Leaves are _pooled_, meaning when a leaf exits the screen it is reset to the top; pooling is used to keep performance steady. 
 
![](/images/projects/floor-games/reusgame/reus_02frogger_collage.jpg)

Below is a code sample of how the leaves handle collision with the player and with one another. Leaves boost through each other, but stop for a player.
I have chosen this snippet because it solves a few design problems regarding interaction with the leaves.
<script src="https://gist.github.com/Rynji/b00232343cd244b3c2757c386c9d8f85.js"></script>

![](/images/projects/floor-games/reusgame/reus_03klimmen_collage.jpg)

Afterwards the players move onto the _climbing_ scene. Here they climb up into a tree, following the main characters instructions. Depth of field is also used here to convey the feeling of height.
Whenever the main character moves it is using a waypoint system I built. Waypoints are placed in the Unity editor. For each waypoint you can choose the animation you want to play (e.g. running, crawling).

![](/images/projects/floor-games/reusgame/reus_waypoint_system.jpg)
<div style="width:100%;height:0px;position:relative;padding-bottom:56.211%;"><iframe src="https://streamable.com/s/6bkdb/vgeguf" frameborder="0" width="100%" height="100%" allowfullscreen style="width:100%;height:100%;position:absolute;left:0px;top:0px;overflow:hidden;"></iframe></div>
The waypoint system and scene setup with perspective and depth of field in action.

----

One of the requirements of all the linear games we're building is that every chapter can be skipped & restarted. For this reason I've built a _phase system_ which controls the flow of the game. 
Every chapter (defined by the designer) is programmed as a _phase_. Phases have a Reset method, a Start method and an End method. Every phase implements this abstract phase class. 
* With the ResetPhase method you make sure all objects are set to their initial state needed to start the phase.
* With the StartPhase method you first call ResetPhase after which you can start the implemented sequences a phase runs through.
* At the end of the phase you call EndPhase which fires the _event_ OnPhaseCompleted. The PhaseController handles this event, makes sure the next phase starts (if there is one) and cleans up.

![](/images/projects/floor-games/system_phase.png)

I used this phase system for all linear games that I've build which is three in total.

----

### Kliederen met Knuffels (Stuffed Animals Mess)
_Kliederen met Knuffels_ is a game about actions & consequences. The players start by making a mess with paint & stuffed animals. Afterwards they have to find the now hiding stuffed animals. A cleanup ensues, followed by bedtime. 
Given this is also a linear game with defined game phases I have used my phase system for this game as well.

For the messing about with paint phase I have worked with particles; I have modified a Unity setup of the particle pool using 1024 particles. 
Every time a stuffed animal moves a certain amount it sends a call to the ParticlePool with its location and an index used for colour. The ParticlePool then takes the next particle from the pool and places it at the correct location with the correct colour. After all 1024 particles have been used the system loops and starts at the first particle again.

Below is a video of the system in action, the ball is used to simulate a single player on the [interactive floor platform](/project/interactive-floor-project).
<div style="width:100%;height:0px;position:relative;padding-bottom:56.000%;"><iframe src="https://streamable.com/s/lszsv/osnpfh" frameborder="0" width="100%" height="100%" allowfullscreen style="width:100%;height:100%;position:absolute;left:0px;top:0px;overflow:hidden;"></iframe></div>
Below is a combined snippet of the core of the particles handling.
<script src="https://gist.github.com/Rynji/4ac674e509a2676cf9588bf4f81a9044.js"></script>

The second phase includes a grid based mechanic where a path of footprints appears. By standing on a footprint it gets cleaned, after all footprints are cleaned an object with potentially the stuffed animal in it spawns.
Due to time constraints I have chosen pre-defined paths (instead of on-the-fly generated paths with pathfinding). These paths are defined in the editor, chosen at random in runtime and rendered on a runtime generated grid.
The grid is generated with each tile as a gameobject. Every tile has two assignable sprites where I display the animals' footprint on.

![](/images/projects/floor-games/knuffelgame/grid.png)

Shown left is the grid/path mechanic as drawn by the designer, on the right is the grid I generated in code.
Below is the code used to generate the grid, a single path and a part of the implementation to show how it is set up & used.
<script src="https://gist.github.com/Rynji/d2c481a8598b2bbf51782f8b596cbbb9.js"></script>

This is what a single path looks like in the editor and ingame. it is easy to create multiple pre-defined paths for the game to choose from.

![](/images/projects/floor-games/knuffelgame/path_editor_game.png)

----

