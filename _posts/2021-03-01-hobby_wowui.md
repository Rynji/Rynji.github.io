---
title: 'WoW Custom UI'
date: 2021-03-01
description: 2021 - Post going over my custom configurated World of Warcraft User Interface.
featured_image: '/images/posts/wowui/header-wowui.png'
---

I have been playing World of Warcraft (WoW) on and off ever since 2005. Customising the user interface has always been a big part of the experience for me. I love being able to customise the interface entirely to my likes and needs.

Digging through my old screenshots from around 2007 we see what I was doing with my interface back then. My screenshots go back to when I was still using a 4:3 screen, good old times. The 3rd screenshot is when I started using UI compilations from other people, this one was called _Caith UI_.
<div class="gallery" data-columns="3">
    <img src="/images/posts/wowui/00_old_4.3.jpg">
    <img src="/images/posts/wowui/00_old_16.9.jpg">
    <img src="/images/posts/wowui/00_old_caith.jpg">
</div>

Around 2016 during and after the Legion expansion I started using the popular [ElvUI](https://www.tukui.org/download.php?ui=elvui) compilation which includes a lot of configurable options and covers almost the entire WoW UI.
Below are three screenshots which show the evolution of my setup going from Legion to Battle for Azeroth to current expansion Shadowlands.

<div class="gallery" data-columns="3">
    <img src="/images/posts/wowui/00st_Legion.png">
    <img src="/images/posts/wowui/0st_BfA.jpg">
    <img src="/images/posts/wowui/zCurrent_Raid_World.jpg">
</div>

For my current setup I have taken inspiration from various other people their UI setups. Combining what I like and what works for me. Currently my setup resembles [RedTuzkUI](https://www.tukui.org/addons.php?id=107) the most; But I have set mine up manually using ElvUI, various other addons and a few small .lua additions I made.

---

The main idea behind the layout is to have all **interface essentials** neatly grouped and in proximity of the **character** area to minimize having to scan the entire screen. 
The interface essentials part has all the vital information you need at your fingertips. The character area is mostly free of UI elements to make it easy to focus on the things happening in the game world. The rest of the elements can go to the sides and have a minimal design as these elements are only read when needed. The elements on the sides have a more minimal design to not cover up the screen with interface elements.

![](/images/posts/wowui/current_focusareas.jpg)

---

When I am not doing any group content but just playing the game solo PvE the interface is as minimal as possible to enjoy the games' visuals. When not in combat most elements fade out or are hidden completely until engaged in combat.

![](/images/posts/wowui/zCurrent_OOC.jpg)

The [objective tracker](https://www.curseforge.com/wow/addons/kaliels-tracker) that includes the questlog is one of the elements I influenced with custom lua code. When not in a group it is located in the top left, but when doing group content with more than 5 people (a raid) the tracker is moved to the right below the minimap. This is done because the raid interface elements are on the left. Moving the tracker based on conditions wasn't possible so I written some lua that handles it.

The code is a very simple check that happens based on the RAID_ROSTER_UPDATE event which is one of the many interface events you can subscribe your own custom code to. Whenever your group size changes it checks if you are in a raid (5+ players usually) and if that is true and the tracker has not been moved yet we move the tracker to the position used for raid groups. The extra check is there to prevent the MoveTrackerForRaid() method executing everytime the group size changes. We only need to move the tracker once.

<script src="https://gist.github.com/Rynji/27412a39ac0e63f37a42afd4609ae320.js" type="text/javascript"></script>

---

A functionality I wanted was to know the total value of all the items in my bags. The addon [Auctionator](https://www.curseforge.com/wow/addons/auctionator) already stores the value of individual items so I was looking for a way to scan my bags and add all the values up.
After doing some searching I [found](https://www.wowhead.com/forums/topic/handy-macros-total-ah-value-in-your-bags-auctioneer-200668) some custom code a user has made to do just that but it wasn't working anymore due to addon and API changes. 

I have modified this code so that it works again for me. I have also registered the code to a slash command; typing /bagsvalue in the chat will run the code.
<script src="https://gist.github.com/Rynji/c2d77d97f29a8a369a7d81480e229116.js"></script>
![](/images/posts/wowui/bagsvalue.png)

---

My main UI profile also has the action bars hidden since I am using a [custom display](https://wago.io/41YukcfQG) to show skill buttons. The action bar is still needed when you are in a vehicle as this modifies your skills to that of the vehicle and you want to see those buttons on the bar.

Toggling visibility of the action bar based on your character being in a vehicle is not possible with ElvUI, but luckily there are UI events surrounding vehicles!
I have written a piece of code that toggles the visiblity of the main action bar when you enter a vehicle and turns it off again when you leave the vehicle.
<script src="https://gist.github.com/Rynji/1c256ac93ce2bf838a43669f30e3bf60.js"></script>

![](/images/posts/wowui/vehiclebar.png)
---


