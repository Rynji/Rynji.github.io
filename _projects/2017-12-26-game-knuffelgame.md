---
title: Kliederen met Knuffels
subtitle: 'A game about actions & consequences for the interactive floor platform'
date: 2017-12-31
description: Linear story telling game
featured_image: '/images/projects/floor-games/floor-games_tile.jpg'
exclude: true
---

### Kliederen met Knuffels (Stuffed Animals Mess)
_Kliederen met Knuffels_ is a game about actions & consequences. The players start by making a mess with paint & stuffed animals. Afterwards they have to find the now hiding stuffed animals. A cleanup ensues, followed by bedtime. 
Given this is also a linear game with defined game phases I have used my [phase system](#fees) for this game as well.

For the messing about with paint phase I have worked with particles; I have modified a Unity setup of the particle pool using 1024 particles. 
Every time a stuffed animal moves a certain amount it sends a call to the ParticlePool with its location and an index used for colour. The ParticlePool then takes the next particle from the pool and places it at the correct location with the correct colour. After all 1024 particles have been used the system loops and starts at the first particle again.

Below is a video of the system in action, the ball is used to simulate a single player on the [interactive floor platform](/project/interactive-floor-project).
<div style="width:100%;height:0px;position:relative;padding-bottom:56.000%;"><iframe src="https://player.vimeo.com/video/467666213" width="640" height="564" frameborder="0" allow="autoplay; fullscreen" allowfullscreen></iframe></div>
Below is a combined snippet of the core of the particles handling.
<script src="https://gist.github.com/Rynji/4ac674e509a2676cf9588bf4f81a9044.js" type="text/javascript"></script>

The second phase includes a grid based mechanic where a path of footprints appears. By standing on a footprint it gets cleaned, after all footprints are cleaned an object with potentially the stuffed animal in it spawns.
Due to time constraints I have chosen pre-defined paths (instead of on-the-fly generated paths with pathfinding). These paths are defined in the editor, chosen at random in runtime and rendered on a runtime generated grid.
The grid is generated with each tile as a gameobject. Every tile has two assignable sprites where I display the animals' footprint on.

![](/images/projects/floor-games/knuffelgame/grid.png)

Shown left is the grid/path mechanic as drawn by the designer, on the right is the grid I generated in code.
Below is the code used to generate the grid, a single path and a part of the implementation to show how it is set up & used.
<script src="https://gist.github.com/Rynji/d2c481a8598b2bbf51782f8b596cbbb9.js" type="text/javascript"></script>

This is what a single path looks like in the editor and ingame. It is easy to create multiple pre-defined paths for the game to choose from.

![](/images/projects/floor-games/knuffelgame/path_editor_game.png)


{% include phase-system.md %}

----

[Back to the interactive floor games overview](/project/interactive-floor-games)