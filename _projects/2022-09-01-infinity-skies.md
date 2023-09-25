---
title: 'Infinity Skies'
subtitle: '(2021-2022) NFT based social castlebuilding game made in Unity'
date: 2022-09-01
description: 'Infinity Skies was a project I worked on as a game developer. It never launched due to the NFT collapse, but substantial development work was done on it, worthy of showcasing. I implemented the entire user interface and worked on developing and prototyping many gameplay elements.'
featured_image: '/images/projects/infinity-skies/isky-header.jpg'
---

Infinity Skies is a The Sims like building & sharing game that was being developed by a company named Dreamfuel Games (which went defunct due to the NFT crash). [Wikkl](https://www.wikkl.me) was responsible for the Unity side of development & the game backend. When I joined Wikkl in 2021 they had been working on Infinity Skies for a few months. We were building the game from the ground up.

I got involved in implementing the entire user interface mainly because I love creating UI. I also had a hand in designing some of the UI layout, but most of it was handled by an artist from DreamFuel games which I worked closely together with. The UI graphics were handed to me from which I handled the implementation in Unity.

---

<div style="width:100%;height:0px;position:relative;padding-bottom:56.211%;"><iframe src="https://player.vimeo.com/video/857501968" width="640" height="359" frameborder="0" allow="autoplay; fullscreen" allowfullscreen></iframe></div>
The games build mode UI in action. Build mode is where players would build castles that other players could visit.
Build mode is entirely built around a grid-based system. The basic grid building system was already functional when I joined but we worked on many extentions afterwards. Some of them which I worked on are: Doors, windows, wall-mountable objects and multi-layer buildables like stairs.

----

Navigating all the user-built castles in Infinity Skies was done through an overworld which had a fixed amount of plots (that could be bought as an NFT 🫧). Ingame this was called the world map which was fully rendered in 3D. During development it was decided there would be a zoomed out overview of the world, more 2D-like. I worked together with an artist to implement this artful worldmap which can be seen in action below. It featured interactive and moving elements displayed over many layers. It's all sprite-based using Unity's sprite rendering system.
<br /> 
<div style="width:100%;height:0px;position:relative;padding-bottom:56.211%;"><iframe src="https://player.vimeo.com/video/867874383" width="640" height="359" frameborder="0" allow="autoplay; fullscreen" allowfullscreen></iframe></div>

----

An adventure mode gametype was also worked on during development but quickly shelved due to the massive amount of work required (the game had a _bit_ of a scoping problem you could say). I worked on prototyping this adventure gamemode for a while. I developed a basic decision tree AI system, droppable equipment, actions and attacks. The user interface was also naturally prototyped by me.
<br /> 
<div style="width:100%;height:0px;position:relative;padding-bottom:56.211%;"><iframe src="https://player.vimeo.com/video/867877174" width="640" height="359" frameborder="0" allow="autoplay; fullscreen" allowfullscreen></iframe></div>

----

A small feature I worked on that is fun to showcase is the 3D clouds that hover over the players island. These clouds are object pooled, move over one axis and they will fade when they are near the player island as to not obscure view of the island.
I used the custom render pipeline feature to render the clouds on their own pass; otherwise they would interfere with other transparent objects on the island as the clouds are still there, just invisible.
<br /> 
<div style="width:100%;height:0px;position:relative;padding-bottom:56.211%;"><iframe src="https://player.vimeo.com/video/867874237" width="640" height="359" frameborder="0" allow="autoplay; fullscreen" allowfullscreen></iframe></div>

----

[Back to projects]({{site.url}})

