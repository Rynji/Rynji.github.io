---
title: 'Interactive Floor Games'
subtitle: 'Highlights from the development of the games I worked on'
date: 2019-12-25
description: Multiple games I developed have released on the Interactive Floor platform the past 2 years. These are some development highlights.
featured_image: '/images/projects/floor-games/reuzentranenSiteSmall.jpg'
---

Below are my personal highlights of the development of the games I've worked on at [Springlab](https://springlab.nl).
Five games have released so far and the sixth is under development.  
Usually, one game designer leads a _game project_ and each game has one game developer (we have 2 of both). The game designer draws out the game using a screen flow; this screen flow is the base which the developers work from.  
I always work closely together with those involved, iterating on implementations to make sure the end result is up to our standards.

----

#### Reuzentranen (Giant's Tears)
This game is built using entirely 2D assets but using a perspective view. Making the gameworld a believable, traversable space. 
_Reuzentranen_ is designed to be an interactive, linear story telling game. Players follow the main-character through a series of events.  

<div class="gallery" data-columns="4">
    <img src="/images/projects/floor-games/reusgame/reus_00intro_design.jpg">
    <img src="/images/projects/floor-games/reusgame/reus_00intro_game.jpg">
	<img src="/images/projects/floor-games/reusgame/reus_02frogger_design.jpg">
	<img src="/images/projects/floor-games/reusgame/reus_02frogger_game.jpg">
</div>

The game starts with an introduction sequence where the camera zooms in through a layer of leaves. I used a sprite shader which writes to depth so I could apply a depth of field post process effect.
This is also used later on when the players climb up a tree, the higher they go the more blurred the background becomes (depth of field).  
From the intro to the tree the players jump from mushroom to mushroom on leaves. 

<div class="gallery" data-columns="4">
    <img src="/images/projects/floor-games/reusgame/reus_03klimmen_design.jpg">
    <img src="/images/projects/floor-games/reusgame/reus_03klimmen_game.jpg">
	<img src="/images/projects/floor-games/reusgame/reus_05hand_design.jpg">
	<img src="/images/projects/floor-games/reusgame/reus_05hand_game.jpg">
</div>

Whenever the main character moves it is using a waypoint system I built. Waypoints are placed in the editor and assigned there, these can vary from walking, running & crawling waypoints.


```csharp
public IEnumerator DoWaypoints()
{
    sharedObjects.PukTopDownObject.GetComponent<BoxCollider2D>().enabled = true; //Collider used to interact with environment in specific levels.
    GameObject pukToMove;

    for (int i = 0; i < waypoints.Count; i++)
    {
        pukToMove = SetCorrectPukObject(waypoints[i]);
        SetCorrectPrefabActive(waypoints[i]);

        if(i != waypoints.Count - 1 && i != waypoints.Count) //Second one obselote, first one catches all. But still...
        {
            Vector3 start, end;
            float time;

            start = waypoints[i].WaypointPosition;
            end = waypoints[i + 1].WaypointPosition;
            time = GetSpeedByWaypoint(waypoints[i].WaypointPosition, waypoints[i + 1].WaypointPosition);

            SetCorrectAnimation(waypoints[i]);

            //Time modifiers to line up speed with specific animations
            if ((int)waypoints[i].PukAnimation == 6 || (int)waypoints[i].PukAnimation == 7 || (int)waypoints[i].PukAnimation == 8) //Walking (down, left & right)
            {
                time *= 1.66f;
            }
            if ((int)waypoints[i].PukAnimation == 11 || (int)waypoints[i].PukAnimation == 12) //Jump left & right
            {
                time = jumpAnimDuration / jumpAnimSpeed;
            }

            //Do actual movement based on current waypoint.
            if (i == 0)//First one eases in.
            {
                yield return StartCoroutine(ReusAnimationHelper.LerpVector3(start, end, time, (x) => pukToMove.transform.localPosition = x, "easein"));
            }
            else if (i == waypoints.Count - 2)//Last one eases out.
            {
                yield return StartCoroutine(ReusAnimationHelper.LerpVector3(start, end, time, (x) => pukToMove.transform.localPosition = x, "easeout"));
            }
            else//Default is just linear movement
            {
                yield return StartCoroutine(ReusAnimationHelper.LerpVector3(start, end, time, (x) => pukToMove.transform.localPosition = x, "linear"));
            }
        }

        else if (i == waypoints.Count - 1)//If actual final waypoint reached, set animation accordingly but don't move.
        {
            sharedObjects.PukTopDownAnimator.SetInteger("State", (int)waypoints[i].PukAnimation);
            pukToMove.transform.localPosition = waypoints[i].WaypointPosition;
        }

        else
        {
            yield return 0;
        }
    }

    sharedObjects.PukTopDownObject.GetComponent<BoxCollider2D>().enabled = false;
    yield return 0;
}
```

<iframe src="https://pastebin.com/embed_iframe/ESAwKZXU" style="border:none;width:100%;height:400px"></iframe>

One of the requirements of all the linear games we're building is that every chapter can be skipped. For this reason I've built a _phase system_ which controls how a phase starts (its state) and it handles the ending of itself.  
This way phases can always be started individually as long as you initiate them properly. This system allows for a reliable way to make multiple chapters in a game 
