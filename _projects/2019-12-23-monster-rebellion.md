---
title: 'Monster Rebellion'
subtitle: '(2017) Location Based Mobile Game using GPS'
date: 2019-12-23
description: Mobile game project I worked on during my bachelor thesis. A mobile game using location coordinates with interaction to stimulate children to walk to school instead of being brought by vehicle.
featured_image: '/images/projects/monster-rebellion/header_screenshot.png'
---

Monster Rebellion is a game [developed for](https://goedopweg.nl/nieuws/ontwikkeling-monster-rebellion) the municipality Utrecht. The goal of the game is to stimulate children in Utrecht to walk to their schools instead of having their parents bring them by car. This is controlled by having the app only be playable during set times when the children travel to and from school.

In the game the players have a shared city which they have to maintain. If not maintained the city will detoriate over time; the city's state is stored in a database. The city is a representation of the real world. By roaming the real world, the game world can be explored. Children can roam the city to find clues. The game only gives you small clues at a single occasion, motivating the children to go out on a regular basis. By collecting clues monster locations can be discovered. Catching monsters will keep the city from deteriorating.

![](/images/projects/monster-rebellion/city_overview.jpg)

The city is generated on an isometric grid in runtime using a 2D array; The generation is done in runtime because the buildings can vary based on the city's state. By catching monsters players can upgrade their city. Location visuals will also unlock on the city overview when visited in real life.

![](/images/projects/monster-rebellion/location_clue.jpg)

A location where clues can be found is shown above. Clues are stored in a players personal room so they can be reviewed later. This project was one of the first where I learned to use LINQ. Some usage can be seen in the snippet below which belongs to the handling of displaying clues in a player's room.

<script src="https://gist.github.com/Rynji/793f763d58e8234b483e421c8557a775.js" type="text/javascript"></script> 

All in all this was a fun project to work on. To go from a paper prototype created by the interaction designer to building an interactive application and [getting it into the players hands](https://www.facebook.com/goedopweg/videos/1543705095743094/).

