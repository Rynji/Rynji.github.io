---
title: Blobbers
subtitle: 'A game about motorics and free play for the interactive floor platform'
date: 2017-12-28
description: Overlap detection game
featured_image: '/images/projects/floor-games/blobbers/niveaus_blobbers.png'
exclude: true
---

### Blobbers
_Blobbers_ is the first game I developed for the [interactive floor platform](/project/interactive-floor-project). The game is rather straightforward; While playing shape outlines will spawn on the floor, players must fill these by standing inside the outlines with their bodies.  
<div style="width:100%;height:0px;position:relative;padding-bottom:44.257%;"><iframe src="https://streamable.com/s/1hre6/khdgsz" frameborder="0" width="100%" height="100%" allowfullscreen style="width:100%;height:100%;position:absolute;left:0px;top:0px;overflow:hidden;"></iframe></div>

----

Unlike the other games this game isn't using anything with colliders or blob detection. What I'm using here is the full frame data from the depth sensor in the RealSense. This depth texture is given as a black & white texture. White pixels are detected areas, black is background. I then compare this depth texture to a white mask texture of each shape to check where the two textures overlap. When a certain threshold of overlap is reached the shape will be set to filled and an animation will play.

![](/images/projects/floor-games/blobbers/hitf_workings.png)

As seen in the image there are two types of textures.
1. The mask: every shape on the field has its own mask converted to a RenderTexture by a camera.
2. The depth frame: Coming from the Intel RealSense in our system I get a realtime texture of the detection.  
Both these textures are the exact same resolution and using the system's calibration are aligned. This way I can use the index of the white pixels on both textures to check for overlap.  
There are two places where I use both these textures. I use them to check for overlap to run the gameplay loop and they are used in a shader I made in Unity's ShaderGraph to display live feedback where there is overlap.
The shader uses a darken blend mode on the two textures and the result is applied to the Alpha channel. The result is that only the overlapping areas are visible on the output of the shader.

Below is the code I've written to check overlap between the two textures and also the shader graph with the shader in action below it.
<script src="https://gist.github.com/Rynji/d69fc2a6d75daac0d655bc9991fa720a.js" type="text/javascript"></script>

![](/images/projects/floor-games/blobbers/shader_graph.png)

![](/images/projects/floor-games/blobbers/shader.png)

The shader can also be seen in action, colour purple, in the video at the top!

----

[Back to the interactive floor games overview](/project/interactive-floor-games)



