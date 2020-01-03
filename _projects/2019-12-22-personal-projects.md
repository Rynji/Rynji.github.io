---
title: 'Personal Projects & Intern'
subtitle: '(2014-2016) Some smaller personal projects & an intership from my bachelor years'
date: 2019-12-22
description: 'Character customiser with interface, day/night cycle game and a spidergame using an on-the-fly generated mesh as a web.'
featured_image: '/images/projects/personal-projects/hibernate_screenshot.png'
---

#### Rumble Run - Character customiser with interface

Internship project made during my bachelor years. I was put on a small team of developers creating a multiplayer mobile runner type game.  
One of the key selling points was to have a custom character you could build to show off to your friends & foes. I took up the task of building this character customiser and the interface surrounding it. 
<br/> <br/>

<div style="width:100%;height:0px;position:relative;padding-bottom:55.886%;"><iframe src="https://streamable.com/s/jcwar/mvmwew" frameborder="0" width="100%" height="100%" allowfullscreen style="width:100%;height:100%;position:absolute;left:0px;top:0px;overflow:hidden;"></iframe></div>

The colour custimisation runs on a custom shader that was written for the game. The character's texture is rendered in realtime using a rendertexture, this way I could change colours on the fly.
Before gameplay starts the texture is saved to an actual static texture. Armour customisation uses anchor points placed on the characters; this is where I parent the armour pieces to.  

![](/images/projects/personal-projects/rumble_run_head_code.png)

If I were tasked with this today I would program it differently; my 2015 implementation has a method for every body piece (!) This is not maintainable in the long run. I would design the system to be more modular and tweakable. 
One thing I do like about the system is that I loaded all the armour pieces through XML. This way designers could add armour pieces and the like to the game without any programming required. Though nowadays I would probably use JSON because it is more widely supported.

![](/images/projects/personal-projects/rumble_run_xml.png)

Besides a lot of programming lessens I learned a lot about user interfaces during this project as well. 

----

#### Mountaineer - Small scope mobile game

Mountainer is a game I programmed back in 2015 where I wanted to create a fully functional game I could play and show on my phone. It is a game of type endless runner where you keep dodging obstacles for as long as possible.  
Object pooling is used for all objects spawning over the 7 lanes the game has. The landscape is endlessly scrolled. I did all the modelling work on this game as well using 3ds Max. It was a fun little project and interesting to make a game from scratch playable on my phone. <br/><br/>

<div style="width:100%;height:0px;position:relative;padding-bottom:49.921%;"><iframe src="https://streamable.com/s/ka05g/jiwlef" frameborder="0" width="100%" height="100%" allowfullscreen style="width:100%;height:100%;position:absolute;left:0px;top:0px;overflow:hidden;"></iframe></div>

The sourcecode can be found on git: [https://github.com/Rynji/Mountaineer](https://github.com/Rynji/Mountaineer/tree/master/Assets)

----

#### SpiderBro - Custom interactable mesh

SpiderBro is a game I created with a group during my bachelor as a school project. You control a spider that can shoot out webs which you use to complete levels in the game.  
The web creation works by creating a triangle mesh on the fly. The first vertex of the triangle is always created at player position, the other 2 vertexes on projectiles. These projectiles stick to a wall thus creating a static web to climb on. The climbing is achieved by adding a mesh collider to the newly created mesh.

<sub>_//Mesh creation code was hosted on the universities' GitLab - trying to recover it..._ </sub><br/>
<br/>

<div style="width:100%;height:0px;position:relative;padding-bottom:56.226%;"><iframe src="https://streamable.com/s/rb7iy/tmjptt" frameborder="0" width="100%" height="100%" allowfullscreen style="width:100%;height:100%;position:absolute;left:0px;top:0px;overflow:hidden;"></iframe></div>

----

#### Nightfall - Day/night cycle used in gameplay

A small game i made during my bachelor years incorporating a day/night cycle into the game mechanics.
The player starts during the day with a goal of finding as much lantern oil as possible to aid him during nighttime. As soon as night falls enemies will spawn and time is limited by how long your lantern will last.  
Your goal is to escape during the night through a randomly placed exit; the light of your lantern being your only guidance.

![](/images/projects/personal-projects/nightfall.png)


