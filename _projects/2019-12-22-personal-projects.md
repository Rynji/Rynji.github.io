---
title: 'Internship & Personal Project'
subtitle: '(2015-2016) A character customiser with an interface & personal game development project'
date: 2019-12-22
description: 'Character customiser with interface and developed mobile game'
featured_image: '/images/projects/personal-projects/hibernate_screenshot.png'
---

#### Rumble Run - Character customiser with interface

Internship project made during my bachelor years. I was assigned to a small team of developers creating a multiplayer mobile runner type game. One of the key selling points was to have a custom character you could build to show off to your friends & foes. I took up the task of building this character customiser and the interface surrounding it as I head a clear vision of how to build this.  
I designed and programmed the character customisation interface. The interface was developed using a grid-based layout with the categories to the side. Regular development builds were tested by stakeholders to get early feedback. The interface is placed in world space with a slight angle, giving it a nice 3D look. The final version included graphics from a graphics artist.
Below are some shots from the interface during development and a video of it in action.

<div class="gallery" data-columns="3">
	<img src="/images/projects/personal-projects/hibernate_ui_01.png">
	<img src="/images/projects/personal-projects/hibernate_ui_02.png">
	<img src="/images/projects/personal-projects/hibernate_ui_03.png">
</div>

<div style="width:100%;height:0px;position:relative;padding-bottom:55.886%;"><iframe src="https://player.vimeo.com/video/467666138" width="640" height="564" frameborder="0" allow="autoplay; fullscreen" allowfullscreen></iframe></div>
<br/>

The colour custimisation runs on a custom shader that was written for the game. The character's texture is rendered in realtime using a rendertexture, this way I could change colours on the fly.
Before gameplay starts the texture is saved to an actual static texture. Armour customisation uses anchor points placed on the characters; this is where I parent the armour pieces to.  

![](/images/projects/personal-projects/rumble_run_head_code.png)

During the development of this game I have learnt the value of modular game design. One example is the code of applying armour pieces to the character (seen above). Each indivdual piece required a change in the game's code. This generated a lot of overhead for code maintenance. The other end of this system was implemented with scalability in mind. New equipment pieces are added through XML. This XML is parsed by the game when it loads all the equipment pieces.

![](/images/projects/personal-projects/rumble_run_xml.png)

Besides a lot of programming lessons, I learned a lot about user interface design during this project as well. 

----

#### Mountaineer - Small scope mobile game

Mountainer is a game I made back in 2015 where I wanted to develop a fully functional game from scratch that I could play on mobile. It is an endless runner type of game where you keep dodging obstacles for as long as possible.  
Object pooling is used for all objects spawning over the 7 lanes the game has. The landscape is endlessly scrolled. I did all the modelling work on this game as well using 3ds Max. It was a fun little project and interesting to make a game from scratch and play it on my own phone. <br/><br/>

<div style="width:100%;height:0px;position:relative;padding-bottom:49.921%;"><iframe src="https://player.vimeo.com/video/467666236" width="640" height="564" frameborder="0" allow="autoplay; fullscreen" allowfullscreen></iframe></div>

I had a lot of fun making these 3D models and being able to interact with these creations in game.

![](/images/projects/personal-projects/mountaineer_models.png)

The source for the game can be found on git: [https://github.com/Rynji/Mountaineer](https://github.com/Rynji/Mountaineer/tree/master/Assets)

----

[Back to projects]({{site.url}})


