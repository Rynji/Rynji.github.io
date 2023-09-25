---
title: 'Match-3 Linker Game'
subtitle: '(2020) A match 3 linker game made for a coding challenge'
date: 2020-04-10
description: 'A tile linking game I developed in 5 days for a coding challenge. Designed as a mobile game, players clear the field by linking adjacent tiles of the same colour. It includes an in-editor level creation tool with several playable levels.'
featured_image: '/images/projects/linker-game/linkerGameBanner.png'
---

### Match-3 Linker Game 

I developed this game in a week for a coding challenge. The requirements were to make a tile linking game designed for mobile play. The player connects tiles of the same colour by swiping from tile to tile. After creating a link of a minimum of 3 tiles the link can be completed by releasing input; this clears the tiles in the link and new tiles are added from the top, collapsing the board down.

#### Game Mechanics
* The Board has 5 different coloured tiles, but supports anything from 2-X, though it wouldn’t work with like 20 different tiles because there wouldn’t be any possible link combinations found.  
* The board size is in theory variable, as it is simply set by 2 variables (rows & columns) but I haven’t implemented code to properly center/scale the grid based on rows & columns, so it is fixed for now. This can easily be expanded upon.  
* Tiles are matched by linking the adjacent tiles based on colour. This is done using an ID which is also the index of which sprite to display from the sprite array on each tile.  
* Matched tiles are removed from the board. 
* The board reshuffles the tiles if no valid links are found.

<br /> At least 3 tiles are required for a match. The way this works is I look for a tile with at least 2 neighbouring tiles of the same colour. This is done in the code sample below.  

<script src="https://gist.github.com/Rynji/e54d7000204b00b1d799c4534dd245ae.js" type="text/javascript"></script>The downside is that with this kind of link searching a link of 4 or more wouldn’t be flagged, because we’re not traversing links of 3, we’re just checking for neighbouring tiles of the same colour (id). This code can be expanded to allow a bigger minimum for links, but due to scope/time I passed on this. 

The board collapses downward on empty tiles, new tiles fill the board from the top. This is done in the RefillGrid Method shown in the snippet below.
<script src="https://gist.github.com/Rynji/11348c369b82a031d000ad85cf352b05.js" type="text/javascript"></script>

The link in progress can be done by swiping back to the previous tile. The swipe controls are shown below taken from the InputHandler.
<script src="https://gist.github.com/Rynji/682e813ec788486799c30e33adfe8cff.js" type="text/javascript"></script>

<div class="gallery" data-columns="3">
	<img src="/images/projects/linker-game/curves.png">
	<img src="/images/projects/linker-game/levelObject.png">
	<img src="/images/projects/linker-game/levelAssignments.png">
	1st image is a tile that is customisable per level. 2nd is the level editor & 3rd is the controller where you place the levels.
</div>

#### Scope
* There are 3 levels for now. The first has unlimited moves and a required score. The other 2 have a required scores and a maximum amount of moves allowed.
* I have made a (simple) level editor in Unity using ScriptableObjects. New level objects can be made through the asset list menu. These levels are then added to the GameController’s level list. This automatically creates a button for the level in the level select menu.
* I have placed some animation curves to edit on the Tiles to accomodate exposed game feel variables.


<div class="gallery" data-columns="3">
	<img src="/images/projects/linker-game/levelSelect.png">
	<img src="/images/projects/linker-game/levelKlompen.png">
	<img src="/images/projects/linker-game/levelHollands.png">
	The level selection which creates a level button from the level ScriptableObjects and two of the levels.
</div>

When I started I had big plans for the look & feel of the game but in the end most of my time was spent working on the main mechanic. The board fill from top was by far the most complicated thing to accomplish. I haven’t used any tutorials or resources in this regard so I spent a lot of time drawing stuff out and figuring out how to get it to work.


As for scalability I would say the project is of such a size right now that it is in the perfect spot for a code review and some refactoring. The final thing I added was audio and due to time constraints I just made it work with what I had. But the calls to the AudioController could be more central through Events for example. Some are called manually now which feels a bit messy. Overall working with the code was really nice. As soon as I had the base game mechanics working I could easily expand upon it by adding a game flow with game over, a menu, multiple levels etc. 
<br />
<br />

<div style="width:100%;height:0px;position:relative;padding-bottom:56.211%;"><iframe src="https://player.vimeo.com/video/857511533" width="640" height="359" frameborder="0" allow="autoplay; fullscreen" allowfullscreen></iframe></div>
<br /> 

As for performance; the board fill feels a bit slower on an older Android device (Nexus 5) so that code would be a target for optimisation for example.
The games look and feel is easily editable through the level ScriptableObject and Tile prefabs. Each level has its own properties including which tiles to use. I have displayed the flexibility of this in my levels as well. The first level only has wooden shoes, the second only tulips and the last level has all the Dutch-themed things combined. 

<!-- ScriptableObjects IMAGE -->

---

The source code for the game is available publicly on GitHub: [https://github.com/Rynji/Linker-Game](https://github.com/Rynji/Linker-Game/tree/develop)

A game build is available in [this zip](https://drive.google.com/open?id=1YuRX2Xsk7Dl2uPGblc2Af5ZKj45kAYyY) with .apk & .exe (Windows).
The game can also be built manually if you don't want to download it. This is done by checking out the Git repo (develop branch) and opening it in Unity 2019.3.


----

[Back to projects]({{site.url}})


