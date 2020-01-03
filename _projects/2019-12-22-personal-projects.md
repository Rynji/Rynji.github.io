---
title: 'Personal Project & Internship'
subtitle: '(2015-2016) A smaller self-made game & an intership from my bachelor years'
date: 2019-12-22
description: 'Character customiser with interface and developed mobile game'
featured_image: '/images/projects/personal-projects/hibernate_screenshot.png'
---

#### Rumble Run - Character customiser with interface

Internship project made during my bachelor years. I was put on a small team of developers creating a multiplayer mobile runner type game.  
One of the key selling points was to have a custom character you could build to show off to your friends & foes. I took up the task of building this character customiser and the interface surrounding it.  
I took on the task of designing the interface, because there wasn't a design for it yet and I had a clear idea of how to implement this interface together with programming the logic behind it.
<br/> <br/>

<div style="width:100%;height:0px;position:relative;padding-bottom:55.886%;"><iframe src="https://streamable.com/s/jcwar/mvmwew" frameborder="0" width="100%" height="100%" allowfullscreen style="width:100%;height:100%;position:absolute;left:0px;top:0px;overflow:hidden;"></iframe></div>

The colour custimisation runs on a custom shader that was written for the game. The character's texture is rendered in realtime using a rendertexture, this way I could change colours on the fly.
Before gameplay starts the texture is saved to an actual static texture. Armour customisation uses anchor points placed on the characters; this is where I parent the armour pieces to.  

![](/images/projects/personal-projects/rumble_run_head_code.png)

If I were tasked with this today I would program it differently; my 2015 implementation has a method for every body piece (!) This is not maintainable in the long run. I would design the system to be more modular and tweakable. 
One thing I do like about the system is that I loaded all the armour pieces through XML. This way designers could add armour pieces and the like to the game without any programming required. Though nowadays I would probably use JSON because it is more widely supported.

![](/images/projects/personal-projects/rumble_run_xml.png)

Besides a lot of programming lessons, I learned a lot about user interface design during this project as well. 

----

#### Mountaineer - Small scope mobile game

Mountainer is a game I made back in 2015 where I wanted to develop a fully functional game from scratch that I could play on mobile. It is an endless runner type of game where you keep dodging obstacles for as long as possible.  
Object pooling is used for all objects spawning over the 7 lanes the game has. The landscape is endlessly scrolled. I did all the modelling work on this game as well using 3ds Max. It was a fun little project and interesting to make a game from scratch and play it on my own phone. <br/><br/>

<div style="width:100%;height:0px;position:relative;padding-bottom:49.921%;"><iframe src="https://streamable.com/s/ka05g/jiwlef" frameborder="0" width="100%" height="100%" allowfullscreen style="width:100%;height:100%;position:absolute;left:0px;top:0px;overflow:hidden;"></iframe></div>

The source can be found on git: [https://github.com/Rynji/Mountaineer](https://github.com/Rynji/Mountaineer/tree/master/Assets)

----

[Back to projects]({{site.url}})


