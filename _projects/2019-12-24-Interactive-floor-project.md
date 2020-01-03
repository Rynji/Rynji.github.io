---
title: 'Interactive Floor Platform'
subtitle: '(2017-2020) From prototype to full grown product with over 100 units sold'
date: 2019-12-24
description: From graduation thesis on tracking in 3D space to prototype to a released product. The platform is used to apply embodied learning in a playful way using interactive games. I've developed its prototype and helped it grow to a fully developed product.
featured_image: '/images/projects/floor-project/floor_project_banner.jpg'
---

The [interactive floor platform](https://springlab.nl/beweegvloer/) is a platform developed at [Springlab](https://springlab.nl) to apply embodied learning for children of ages 2-4. 

In February 2017 I started my bachelor thesis[^1] research at Springlab. The interactive floor project was in its earliest stages; market research was being conducted but there wasn't a proof of concept yet. My goal was to find a suitable method of tracking players in a 3D space from a top down position which could be used to build a prototype with.

I started out by exploring the OpenCV Computer Vision library in C++. I built some examples around colour based detection in C++ <sup>(p21-29 in my thesis[^1]).</sup> While the results were promising, colour tracking wasn't feasible for the interactive floor since we didn't want players to wear specific marker based items and such. I did end up completing my thesis using colour detection because I wanted to spent time on porting the C++ to Unity and to explore some tracking algorithms. The end result of my thesis was contour detection of individual items on a colour filtered binary image working in Unity. 

![](/images/projects/floor-project/colour_contour_detection.jpg)

After completing my bachelor I started building a prototype interactive floor for Springlab. I had access to a Microsoft Kinect camera and an OpenCV for Unity plugin. I mainly worked together with an interaction designer who took care of setting up a prototype hardware box and designing the interactions.

The prototype can be seen in action in the video below.
<iframe src="https://www.youtube.com/embed/dJ-woBDXpAQ" width="640" height="360" frameborder="0" webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>
Below is a picture of our prototype. To minimize shadows on the play area, we experimented with multiple beamers. Unfortunately, aligning the multiple beamers proved to be impractical.

![](/images/projects/floor-project/first_active_prototype.jpg)

We tested this prototype with the interactive games on multiple occasions at daycare(s) which proved successful. With the help of this prototype the interactive floor project gained momentum.
I started a full time job as a game developer together with one other developer who would take care of the tracking department. I started the project working on the tracking code, but since I am more interested in gameplay programming I transitioned onto game development for this project. I laid the foundations for the setup of the entire application that is still running for more than 100 customers today; I also setup and manage the GitHub version control with pull requests, code reviews, logical commits and the like.

[^1]: [download thesis in pdf here (Dutch)](/documents/bachelor-thesis.pdf)
