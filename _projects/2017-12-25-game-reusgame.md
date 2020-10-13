---
title: Reuzentranen (Giant's Tears)
subtitle: 'An engaging storytelling game for the interactive floor platform'
date: 2017-12-31
description: Linear storytelling game
featured_image: '/images/projects/floor-games/floor-games_tile.jpg'
exclude: true
---

### Reuzentranen (Giant's Tears)
This game is built using entirely 2D assets but using a perspective view. Making the gameworld a believable, traversable space. 
_Reuzentranen_ is designed to be an interactive, linear storytelling game. Players follow the main-character through a series of events.

For this game I built a [phase system](#fees) used in multiple games. The game starts with an introduction sequence where the camera zooms in through a layer of leaves. I used a sprite shader which writes to the depth buffer so I could apply a depth of field post process effect.
This depth of field effect is used throughout the game. 

![](/images/projects/floor-games/reusgame/reus_00intro_collage.jpg)

The next sequence has the players jump from leaf to leaf to reach the next dry 'land'. Leaves freeze when stepped on to help the players cross.  
Leaves are _pooled_, meaning when a leaf exits the screen it is reset to the top; pooling is used to keep performance steady. 
 
![](/images/projects/floor-games/reusgame/reus_02frogger_collage.jpg)

Below is a code sample of how the leaves handle collision with the player and with one another. Leaves boost through each other, but stop for a player.
I have chosen this snippet because it solves a few design problems regarding interaction with the leaves.
<script src="https://gist.github.com/Rynji/b00232343cd244b3c2757c386c9d8f85.js" type="text/javascript"></script>

![](/images/projects/floor-games/reusgame/reus_03klimmen_collage.jpg)

Afterwards the players move onto the _climbing_ scene. Here they climb up into a tree, following the main characters instructions. Depth of field is also used here to convey the feeling of height.
Whenever the main character moves it is using a waypoint system I built. Waypoints are placed in the Unity editor. For each waypoint you can choose the animation you want to play (e.g. running, crawling).

![](/images/projects/floor-games/reusgame/reus_waypoint_system.jpg)
<div style="width:100%;height:0px;position:relative;padding-bottom:56.211%;"><iframe src="https://player.vimeo.com/video/467666262" width="640" height="359" frameborder="0" allow="autoplay; fullscreen" allowfullscreen></iframe></div>
The waypoint system and scene setup with perspective and depth of field in action.

{% include phase-system.md %}

----

[Back to the interactive floor games overview](/project/interactive-floor-games)