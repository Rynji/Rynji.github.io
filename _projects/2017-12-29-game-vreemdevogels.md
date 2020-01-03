---
title: Vreemde Vogels
subtitle: 'A game about family and recognition for the interactive floor platform'
date: 2017-12-29
description: Family & recognition game
featured_image: '/images/projects/floor-games/system_phase.png'
exclude: true
---

### Vreemde Vogels (Unfamiliar Birds)

Another linear story telling game based around recognizing animal types and the such. I also used my [phase system](#fees) for this game. I worked closely with the game designer on this game project to keep the scope as small as possible while still delivering within target. 
Building with the phase system and a main mechanic based around re-using the same logic meant this game was developed rather quickly.

The players start out in a garden, chill a bit and explore after which a little bird falls from the sky. The first task for the players is to calm this bird.  
The mechanic is designed around approaching the bird slowly. If the players approach the bird too quickly it will scower away in fear. The bird has three invisible circles around itself. The initial design had four circles but the playable area was too small for such precise detection so we went with three. When a player hits a circle the time this circle was hit is registered, when the next circle is hit as well. These hit times are used to check how fast you are approaching. If you slow enough you are allowed to trigger the next circle otherwise the bird wil fly away!
<div style="width:100%;height:0px;position:relative;padding-bottom:55.102%;"><iframe src="https://streamable.com/s/2dj8s/xptvhk" frameborder="0" width="100%" height="100%" allowfullscreen style="width:100%;height:100%;position:absolute;left:0px;top:0px;overflow:hidden;"></iframe></div>
Video showing the mechanic (with debug circles active) in action. The tomato is used in-editor to simulate a player on the floor. Code is shown below.
<script src="https://gist.github.com/Rynji/6a3b6c37eb9ac84e0c6065a75000e350.js" type="text/javascript"></script>

The snippet above is not something to be proud of. Recurring checks written in a sequential matter does not improve readability of the code. In this case the code works well for the game, but a refactor would have not been out of place here.

Next up comes the main mechanic of the game. The players are tasked with comparing the bird to different kinds of animals entering the screen. After 3 comparisons the bird's family will enter the screen and they'll live happily ever after.  
One of the cooler challenges was making a magnifying glass used to examine the animals under. I ended up using sprite masks. The magnifying glass is a mask, under this mask a big version of the animals is visible; outside this mask a small one is visible. See it in action and from design to ingame below.

![](/images/projects/floor-games/vreemdevogels/vogels_vergrootglas_collage.png)
<div style="width:100%;height:0px;position:relative;padding-bottom:56.098%;"><iframe src="https://streamable.com/s/5ha38/osgmrh" frameborder="0" width="100%" height="100%" allowfullscreen style="width:100%;height:100%;position:absolute;left:0px;top:0px;overflow:hidden;"></iframe></div>

During this gameplay phase the players are asked questions by the main character like: "Do these animals have the same colour as the bird?". The players then have to answer this question which the teacher inputs in the second screen application as either good (next question) or wrong (repeat question). The code for this phase is super straightforward. It is basically an IEnumerator with a switch case on the questionIndex. Audio files get played according to which question the players are on.  
This repeats for every new family until the third has been completed, after this the birds family enters the screen which leads to the ending of the game.

Families are setup in a modular way, all using the same scripts. Families can easily be expanded and added. No programming is needed to add new animals and families so content updates can easily be accomplished.

![](/images/projects/floor-games/vreemdevogels/family_setup.png)


{% include phase-system.md %}

----

[Back to the interactive floor games overview](/project/interactive-floor-games)




