---
title: 'Baby Builder'
subtitle: '(2020-2021) A playful exploration of genetic engineering'
date: 2021-02-01
description: 'The Baby Builder is an interactive installation built in Unity/C# in which you can design your own child through genetic engineering. The Baby Builder is a self-initiated project by Bertrand Burgers; it challenges the audience to confront the ethical, societal and moral questions raised by the development of genetic engineering.'
featured_image: '/images/projects/baby-builder/bb-header-large.jpg'
---

#### 2021 Update

It is now possible to [book](https://static1.squarespace.com/static/5f0dae9666df150ca89f6b1b/t/5f9e9af0e9a0e4631a01f89c/1604229878964/digital-form-baby-builder.pdf) the Baby Builder. The installation has proven to be a perfect match for places (e.g. festivals, exhibitions, museums, schools) on the cutting edge of technology, science and art. 

To accomodate the exposition of the installation we have updated it with some quality of life changes. 
One of the new features is an automated reset that occurs if there hasn't been user-input for more than 90 seconds. This has been implemented to allow the installation to keep running on its own, even if a user abandons the installation halfway through. Among other things we have also simplified the survey at the end.


<div class="gallery" data-columns="6">
    <img src="/images/projects/baby-builder/unity/ui_afkscreen.png" height="25%">
    <img src="/images/projects/baby-builder/unity/ui_survey_new.png" height="25%">
</div>

We also implemented an option for the user to opt out of any data being saved. The data we save from the session is already pretty limited, but choosing to opt-out doesn't save any session data at all. All it does is add an entry that the user opted out; this way we can still confirm that the user completed an entire session of the Baby Builder.

----

#### The Project

The Baby Builder is an interactive installation in which you can design your own child through genetic engineering. It is built using the Unity engine and designed for use on touch screens. I worked on the application from the prototyping phase onwards. I have now developed it into a full-fledged application that has been on display at several exhibitions and festivals. The Baby Builder has also been nominated for the Young Talent Award at the Dutch Design Week 2020.

![](/images/projects/baby-builder/bb-interaction.jpg)
> *"Whatever your point of view may be, the Baby Builder challenges the audience to confront the ethical, societal and moral questions raised by the development of genetic engineering."[^1]* 

[^1]: Bertrand Burgers, [bertrandburgers.com](https://www.bertrandburgers.com)

I developed the interface of Baby Builder to be scaleable to most, if not all, aspect ratios. Since the design went through quite some iterations I made sure that the moving around of elements wouldn't impact my development time.
The result is a very flexible application that can be displayed on any kind of screen. Be that on a mobile phone, a tablet or a large touchscreen for example. 

<div class="gallery" data-columns="3">
    <img src="/images/projects/baby-builder/unity/ui_18by9.PNG">
    <img src="/images/projects/baby-builder/unity/ui_5by4.PNG">
    <img src="/images/projects/baby-builder/unity/ui_16by9.PNG">
</div>

----

The first iteration started out with a simple interactive prototype. After prototype testing with several test groups, an improved design was created and delivered to me. You can see some frame elements carrying over in the screenshots of the first and second prototype below. The first prototype was pretty limited so most elements were created from scratch while implementing the final design.

<div class="gallery" data-columns="2">
    <img src="/images/projects/baby-builder/unity/bb-initial-prototype.PNG">
    <img src="/images/projects/baby-builder/unity/bb-initial-design.PNG">
</div>

----

Given the design contains many recurring elements; I made sure to develop all frames modularly based on prefabs. Updating existing frames or adding new ones is just a matter of using/editing the building blocks already created.

![](/images/projects/baby-builder/unity/prefabs-collage.PNG)

----

The Baby Builder gives you a score at the end based on how many modifications you applied. This score is calculated from each frame using *Scoring Modules*. Scoring modules are currently configured by hand and manually plugged into the score calculator. In case of further development I would rewrite this to a dynamic system that passes through all frames and calculates scores based on the contents of the frame automatically.

One of the requirements for the Baby Builder was to store the data produced by the application. Given the limited scope of the project I solved this by locally saving the data. All data produced from the application is saved to a single comma seperated file (.csv). The file creates a backup after every session. An example of the data saved is shown below.

![](/images/projects/baby-builder/bb_data.png)

----

The video below shows the Baby Builder application front to back.

<iframe width="560" height="315" src="https://youtube.com/embed/HtT2TPZJG68" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>

<div class="gallery" data-columns="3">
	<img src="/images/projects/baby-builder/Baby-Builder-portrait.jpg">
	<img src="/images/projects/baby-builder/baby-builder-foto-klein1.jpg">
    <img src="/images/projects/baby-builder/baby-builder-foto-klein2.jpg">
    <img src="/images/projects/baby-builder/baby-builder-foto-klein3.jpeg">
    <img src="/images/projects/baby-builder/baby-builder-foto-klein4.jpg">
</div>


----

[Back to projects]({{site.url}})


