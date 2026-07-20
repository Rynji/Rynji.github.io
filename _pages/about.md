---
title: About me
subtitle: Personal story & skills
description: A little bit of text about who I am and what I do and a summary of my professional skills.
featured_image: /images/headers/about.jpg
---

{% assign age = site.time | date: '%Y' | minus: site.birth_year %}
{% assign current_month = site.time | date: '%-m' | plus: 0 %}
{% if current_month < site.birth_month %}{% assign age = age | minus: 1 %}{% endif %}
## Hi there! 

I’m Timon Nap — a {{ age }}-year-old Unity/C# developer based in the Utrecht area (NL), with over 7 years of experience building interactive 3D applications, serious games, and simulation-driven tools.

My work centers on gameplay systems, UI implementation, and making prototypes production-ready — from entertainment games like [New Heights](/project/new-heights) to AR/VR [training tools](/project/innovam) for the automotive industry. I enjoy building clean, modular systems that scale, especially within real-world constraints and existing codebases (BSc Computer Science, AUAS 2017).

These days, agentic AI tooling is a core part of how I work: I direct AI coding agents to move faster on implementation while keeping architecture, review, and quality firmly in my own hands.

Outside of work I’m into weightlifting, cycling, and tinkering with tech — including my own Yaris GRMN, which I maintain and upgrade for fun and function. I also travel to lesser-known destinations: Armenia (2023), Kazakhstan (2019), and Ukraine (2018).
 

## Skills & Tools

[Curriculum Vitae](/documents/cv-timon-public.pdf)


**Programming & Game Development**  
C#, Unity (URP & Built-in), Netcode for GameObjects (NGO), Unity Localization, DOTween, ScriptableObject architecture, modular interaction systems, custom editor tools

**AI-Assisted Development**  
Agentic coding workflows (Claude Code, GPT-Codex), spec-driven prompting, AI output review & verification, applying AI agents safely to large existing codebases

**UI & Visual Design**  
Unity uGUI, responsive in-game UI systems, localisation workflows, Photoshop, Blender (basic), photogrammetry & PBR texturing (Materialize)

**AR/VR & Simulation Tools**  
AR Foundation, Oculus Quest development (Unity), animation-driven interaction systems, scenario-based training flows, light simulation logic (procedural / state-driven)

**Web & Hybrid Development**  
AngularJS (legacy), Ionic, BabylonJS, Tailwind CSS, HTML/CSS

**Workflow & Collaboration**  
Git, GitHub, Trello, version control best practices, feature branching, Agile & Scrum (small to mid-sized teams), CI basics


